using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Win32;

namespace FitxersBinaris
{
    public class BinariArticles
    {
       // public enum Acces { SEQUENCIAL,DIRECTE };
        public const int RSIZE = 175;
        private string fileName;
        
        private FileStream fIn;//apertura en modus lectura per defecte ( operacions R )
        private FileStream fOut; // en operacions C-U-D tancarem fIn i obrirem fOut.
                                 // En acabar farem l'operació tancarem fOut i tornarem a deixar obert fIn
        private BinaryReader fArticles;
        private BinaryWriter fArticlesW;
        private int registres;
        private long posicio;
        private long primeraPosicioLliure; //només per altes
        /// <summary>
        /// obrim fIn i fArticles i actualitzem posició al valor fIn.position
        /// </summary>
        /// <param name="fileName"></param>
        
        public BinariArticles(string fileName)
        {
            fIn = new FileStream(fileName, FileMode.Open, FileAccess.Read);
            fArticles = new BinaryReader(fIn);
        }
        /// <summary>
        /// Fem accés directe a l'article amb número de registre nRegistre
        /// Retornem l'article (sigui quin sigui, fins i tot si obtenim un registre eliminat)
        /// I finalment posicionem el punter al principi d'aquest registre
        /// </summary>
        /// <param name="nRegistre">número de registre a llegir del fitxer</param>
        /// <returns></returns>
        public Article GetArticle(int nRegistre)
        {
            posicio = Num2Pos(nRegistre);
            fIn.Position = fIn.Seek(posicio, SeekOrigin.Begin);
            Article unArticle = new Article(fArticles.ReadInt32(), fArticles.ReadString(), fArticles.ReadString(),
                               fArticles.ReadDouble(), fArticles.ReadString(), fArticles.ReadString());
            fIn.Seek(0, SeekOrigin.Begin);
            return unArticle;
        }
        /// <summary>
        /// Ens posicionem en el registre amb número de registre = nRegistre
        /// tanquem fIn
        /// Obrim fOut
        /// Ens posicionem en el registre nRegistre
        /// Escribim -1 en la posició que toca
        /// Tanquem el flux d'escriptura i seguidament reobrim el de lectura
        /// </summary>
        /// <param name="nRegistre"></param>
        public void DeleteArticle(int nRegistre)
        {
            fIn.Close();
            fArticles.Close();
            fOut = new FileStream("articles.bin", FileMode.Open, FileAccess.Write);
            fArticlesW = new BinaryWriter(fOut);
            fOut.Seek(nRegistre, SeekOrigin.Begin);
            fArticlesW.Write(-1);
            fOut.Close();
            fIn = new FileStream(fileName, FileMode.Open);
            fArticles = new BinaryReader(fIn);
        }

        /// <summary>
        /// Tanquem flux de lectura (fIn) i obrim Escriptura (fOut)
        /// Escribim tots els camps ordenadament, seguint el format del fitxer
        /// I assegurant que la longitud de cada camp és la que toca
        /// Completant els camps amb blancs a la dreta
        /// finalment tanquem flux d'escriptura i obrim de lectura
        /// </summary>
        /// <param name="unArticle">Article a actualitzar a la posició unArticle.N</param>
        public void UpdateArticle(Article unArticle)
        {
            fIn.Close();
            fArticles.Close();
            fOut = new FileStream("articles.bin", FileMode.Open, FileAccess.Write);
            fArticlesW = new BinaryWriter(fOut);
            fOut.Seek(unArticle.N, SeekOrigin.Begin);
            ////////////////////////////////////////////////////////////// no acabat
        }
        /// <summary>
        /// tamquem flux d'entrada i obrim de sortida
        /// Hem de detectar si volem afegir al final (paràmetre pos)
        /// O bé al mig. Si és al mig hem d'obrir flux de sortida en modus ReadWrite
        /// Si és al final, hem d'obrir en modus Append
        /// Escribim camps i tanquem sortida i obrim flux d'entrada
        /// </summary>
        /// <param name="unArticle"></param>
        /// <param name="pos"></param>
        public void AddArticle(Article unArticle, long pos)
        {
            fIn.Close();
            fArticles.Close();
            fOut = new FileStream("articles.bin", FileMode.Open, FileAccess.Write);
            fOut.Seek(unArticle.N, SeekOrigin.Current);
            fArticlesW = new BinaryWriter(fOut);
            fArticlesW.Write(unArticle.N);
            fArticlesW.Write(unArticle.Codi);
            fArticlesW.Write(unArticle.Descripcio);
            fArticlesW.Write(unArticle.Preu);
            fArticlesW.Write(unArticle.Color);
            fArticlesW.Write(unArticle.Talla);
            fOut.Close();
            fIn = new FileStream(fileName, FileMode.Open);
            fArticles = new BinaryReader(fIn);
        }
        /// <summary>
        /// A partir del número de registre, calcular i retornar el byte on 
        /// comença el registre
        /// </summary>
        /// <param name="numRegistre">número de registre</param>
        /// <returns>byte inicial que ocupa el registre amb N= numRegistre</returns>
        public long Num2Pos(int numRegistre)
        {
            return RSIZE * (numRegistre - 1);
        }
        /// <summary>
        /// Obtenim el número de registre que ocuparia un registre si comencés en 
        /// el byte número "pos"
        /// </summary>
        /// <param name="pos"></param>
        /// <returns></returns>
        public int Pos2Num(long pos)
        {
            return (int)pos / RSIZE + 1;
        }
        /// <summary>
        /// Per afegir nous registres, fa una cerca d'un -1 en el número de registre
        /// Si ho troba, es posiciona al principi del registre trobat (per posteriorment inserir)
        /// Si no troba, es posiciona en el final de fitxer 
        /// Actualitza l'atribut primeraPosicioLliure un cop feta la cerca
        /// </summary>
        public void AnarAPrimeraPosicioLliure()
        {
            fOut.Seek(Num2Pos(-1), SeekOrigin.Begin);
        }

        /// <summary>
        /// retorna la posició del punter del fitxer (byte)
        /// </summary>
        public long Posicio
        {
            get { return posicio; }
        }

        /// <summary>
        /// A partir de la posició actual, 
        /// retornem el número de registre actual on estem posicionats
        /// /// És una fòrmula, no bucle!
        /// </summary>
        public int NumRegActual
        {
            get
            {
                return Pos2Num(Posicio);
            }
        }

        /// <summary>
        /// Retorna el nombre de registres ja escrits (encara que tinguin -1)
        /// És una fòrmula, no bucle!
        /// </summary>
        public long Registres
        {
            get
            {
                return (Tamany / RSIZE) / 2;

            }
           
        }
        /// <summary>
        /// Bytes totals del fitxer
        /// </summary>
        public  long Tamany
        {
            get
            {
                return fIn.Length;
            }
        }
        /// <summary>
        /// Retorna el valor de l'atribut primeraPosicioLliure. No hi ha set
        /// </summary>
        public long PrimeraPosicioLliure 
        { get
            {
                return primeraPosicioLliure;
            }
        }
    }
}
