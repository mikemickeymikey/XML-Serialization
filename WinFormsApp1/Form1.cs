using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using FitxersBinaris;
using Microsoft.VisualBasic;

namespace WinFormsApp1
{
    public partial class frmArticles : Form
    {
        private BinariArticles fArticles;   // referència que ens servirà per fer els accessos directes a les dades
        private SerialitzadorArticles serialitzadorArticles;
        private XMLArticles xmlArticles;
        private Article currentArticle;   // en algunes ocasions contindrà l'article actual que estem manipulant 
        private int numRegistrePerAlta;  // només el farem servir per actualitzar el número de registre
                                         // que s'ha de donar d'alta en el cas de les altes
        private const string NOMFITXER = "articles.xml";
        private const string NOMFITXERBIN = "articles.bin";
        private const string NOMFITXEREXPORTAR = "infoArticles.txt";
        private string currentCodiArticle; //El farem servir per altes XML cancel·lades.
        


       

        /// <summary>
        /// Inicialitza el fitxer "ARTICLES.BIN" usant l'acció InicialitzaFitxer
        /// Informem en el textBox txtRegistres el rang de registres creats a disc
        /// Cal calcular el total de registres i mostrar 1-TOTAL , per exemple 1-1130
        /// 
        /// </summary>
        public frmArticles()
        {
            InitializeComponent();
            btnConfirmarAlta.Enabled = false;
            btnCancelAlta.Enabled = false;
            InicialitzaFitxer(NOMFITXERBIN);
            if (File.Exists(NOMFITXER))
            {
                serialitzadorArticles = new SerialitzadorArticles(NOMFITXER);
                xmlArticles = new XMLArticles(NOMFITXER);
                txtRegistres.Text = "1-" + fArticles.Registres.ToString();
            }
        }

        
        /// <summary>
        /// Si hi ha registres al fitxer, carreguem el registre número 1
        /// en cas contrari donem un missatge "FITXER BUIT"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmArticles_Load(object sender, EventArgs e)
        {
            btnDoAltaXML.Enabled = false;
            btnCancelAltaXML.Enabled = false;
            if (new FileInfo(NOMFITXERBIN).Length != 0)
            {
                Article unArticle = fArticles.GetArticle(1);
                txtNum.Text = unArticle.N.ToString();
                txtCodiArticle.Text = unArticle.Codi;
                txtDescripcioArticle.Text = unArticle.Descripcio;
                txtTalla.Text = unArticle.Talla;
                txtColor.Text = unArticle.Color;
                txtPreu.Text = unArticle.Preu.ToString();
                currentArticle = unArticle;
            }
            else MessageBox.Show("FITXER BINARI BUIT");
        }
         
        
        /// <summary>
        /// Si currentArticle té com a número -1, vol dir que no es pot modificar ja que s'ha eliminat prèviament
        /// En cas contrari actualitzarem la resta de camps, creant un nou Article amb tots els camps procendents
        /// dels textboxes corresponents i cridarem a UpdateArticle de la classe BinariArticles
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnUpdateRecord_Click(object sender, EventArgs e)
        {
           if(currentArticle.N != -1)
            {
                Article unArticle = new Article(currentArticle.N, txtCodiArticle.Text, txtDescripcioArticle.Text,
                    double.Parse(txtPreu.Text), txtColor.Text, txtTalla.Text);
                fArticles.UpdateArticle(unArticle);
            }
        }
        /// <summary>
        /// Fa accés directe al registre contingut al textbox txtRegToGo. Control d'excepció per format erroni.
        /// Control de rang de registres entre 1 i el total de registres del fitxer
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnGoToRecord_Click(object sender, EventArgs e)
        {
            if (int.Parse(txtRegToGo.Text) < 1 || int.Parse(txtRegToGo.Text) > fArticles.Registres) throw new ArgumentOutOfRangeException();
            Article unArticle = fArticles.GetArticle(int.Parse(txtRegToGo.Text));
            if (unArticle != null)
            {
                txtNum.Text = unArticle.N.ToString();
                txtCodiArticle.Text = unArticle.Codi;
                txtDescripcioArticle.Text = unArticle.Descripcio;
                txtTalla.Text = unArticle.Talla;
                txtColor.Text = unArticle.Color;
                txtPreu.Text = unArticle.Preu.ToString();
            }
        }
        /// <summary>
        /// Si el número de registre actual (currentArticle.N) és -1, no es pot esborrar
        /// En cas contrari cridarem a fArticles.DeleteArticle passant-li  el número d'article a esborrar
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDeleteCurrentRecord_Click(object sender, EventArgs e)
        {
            if (currentArticle.N != -1) MessageBox.Show("Aquest article no es pot borrar.");
            else fArticles.DeleteArticle(currentArticle.N);
        }

        
        //Posicionarem el punter a la primera posició lliure (per afegir)
        //usant la classe BinariArticle, obtindrem el byte en què ens hem posicionat
        // i el número de registre associat a la posició.
        // en acabar queden habilitats els botons de confirmar o cancel·lar alta
        // actualitzarem la variable numRegistrePerAlta, per si ens confirmen l'alta
        //posteriorment
        private void btnAddRecord_Click(object sender, EventArgs e)
        {








            //última instrucció d'aquest mètode
            SwitchToAltes(true);

            


        }

        /// <summary>
        /// Posem el txtNum.Text="-1" i la resta de camps en blanc. Informem "ALTA CANCEL.LADA
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCancelAlta_Click(object sender, EventArgs e)
        {   //Primera instrucció d'aquest mètode
            SwitchToAltes(false);
            




        }
        /// <summary>
        /// Creem un nou article, amb el número de registre = numRegistrePerAlta
        /// i la resta d'atributs = al contingut dels textboxes de dades
        /// Afegim el registre amb el mètode fArticles.AddArticle passant com a paràmetre
        /// l'article nou i el byte corresponent a la primera posició lliure (trobada anteriorment)
        /// Actualitzem el textbox on informa del rang de registres existents 1-1130 etc.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnConfirmarAlta_Click(object sender, EventArgs e)
        {





            //última instrucció d'aquest mètode
            SwitchToAltes(false);

        }

        private void btnExportToTxt_Click(object sender, EventArgs e)
        {
            frmExport fExport = new frmExport(fArticles);
            fExport.ShowDialog();

        }
        private void btnSerialitzar_Click(object sender, EventArgs e)
        {
            string rang = Interaction.InputBox("Entra el registre inicial i final a serialitzar en format: nInici-nFinal");
            string[] camps = rang.Split("-");
            int min = int.Parse(camps[0]);
            int max = int.Parse(camps[1]);
            if (min < 0 || max > fArticles.Registres) throw new ArgumentOutOfRangeException();
            int count = min;
            Article article;
            List<Article> llistaArticles = new List<Article>();
            while (count <= max)
            {
                article = fArticles.GetArticle(count);
                if (article.N != -1) llistaArticles.Add(article);
                count++;
            }
            serialitzadorArticles = new SerialitzadorArticles(NOMFITXER);
            serialitzadorArticles.SerialitzaLlistaArticles(llistaArticles);
            txtDocumentXML.Text = xmlArticles.TotElContingutXML();
        }
        #region elsmeusmetodesprivats
        private void SwitchToAltes(bool faigAlta)
        {
            btnConfirmarAlta.Enabled = faigAlta;
            btnCancelAlta.Enabled = faigAlta;
            btnAddRecord.Enabled = !faigAlta;
            btnDeleteCurrentRecord.Enabled = !faigAlta;
            btnUpdateRecord.Enabled = !faigAlta;
            btnExportToTxt.Enabled = !faigAlta;
            btnGoToRecord.Enabled = !faigAlta;
        }
        /// <summary>
        /// Accedeix a la classe BinariArticles per obtenir l'article amb número de registre nR
        /// Si en accedir, trobem que el número de registre és -1, llavors és mostra
        /// -1 en el codi de registre i "" en la resta de textboxes.
        /// Si l'article existeix, es carreguen les dades als textboxes.
        /// IMPORTANT: Actualitzar atribut currentArticle a l'article carregat
        /// </summary>
        /// <param name="nR">número de registre a trobar</param>
        private void CarregarRegistre(int nR)
        {
            Article unArticle = fArticles.GetArticle(nR);
            if (unArticle != null)
            {
                currentArticle = unArticle;
                if (unArticle.N != -1)
                {
                    txtNum.Text = "-1";
                    txtCodiArticle.Text = "";
                    txtDescripcioArticle.Text = "";
                    txtTalla.Text = "";
                    txtColor.Text = "";
                    txtPreu.Text = "";
                }
                else
                {
                    txtNum.Text = unArticle.N.ToString();
                    txtCodiArticle.Text = unArticle.Codi;
                    txtDescripcioArticle.Text = unArticle.Descripcio;
                    txtTalla.Text = unArticle.Talla;
                    txtColor.Text = unArticle.Color;
                    txtPreu.Text = unArticle.Preu.ToString();
                }
            }
            else MessageBox.Show("No s'ha trobat el registre.");
        }

        /// <summary>
        /// Crea una referència de tipus BinariArticles
        /// </summary>
        /// <param name="fileName">nom físic del fitxer</param>
        private void InicialitzaFitxer(String fileName)
        {
            fArticles = new BinariArticles(fileName);
        }
        #endregion
        #region ignorar
        private void txtRegistres_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void menuStrip1_ItemClicked_1(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void menuStrip1_ItemClicked_2(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void menuStrip1_ItemClicked_3(object sender, ToolStripItemClickedEventArgs e)
        {

        }
        #endregion

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnCercaXMLPerCodi_Click(object sender, EventArgs e)
        {
            string codi = Interaction.InputBox("Entra el codi del registre a cercar");
            Article unArticle = xmlArticles.GetArticle(codi);
            txtNum.Text = "";
            txtCodiArticle.Text = unArticle.Codi;
            txtCodiArticle.Enabled = false;
            txtDescripcioArticle.Text = unArticle.Descripcio;
            txtTalla.Text = unArticle.Talla;
            txtColor.Text = unArticle.Color;
            txtPreu.Text = unArticle.Preu.ToString();
        }

        private void btnUpdateXML_Click(object sender, EventArgs e)
        {
            MessageBox.Show("SOBRE EL FITXER XML ACTUALITZAREM EL NODE AMB CODI D'ARTICLE\n" +
                " CONTINGUT EN EL TEXT BOX txtCodiArticle\n");
            Article unArticle = new Article(currentArticle.N, txtCodiArticle.Text, txtDescripcioArticle.Text,
                    double.Parse(txtPreu.Text), txtColor.Text, txtTalla.Text);
            bool actualitzat = xmlArticles.UpdateNode(unArticle);
            if (actualitzat) MessageBox.Show("Actualitzat correctament.");
            else MessageBox.Show("No s'ha pogut actualitzar.");
        }

        private void btnDeleteXML_Click(object sender, EventArgs e)
        {
            //https://stackoverflow.com/questions/20611/removing-nodes-from-an-xmldocument
            bool eliminat = xmlArticles.DeleteNode(txtCodiArticle.Text);
            if (eliminat) MessageBox.Show("Eliminat correctament.");
            else MessageBox.Show("No s'ha pogut eliminar.");
        }

        private void btnAddXML_Click(object sender, EventArgs e)
        {
            //https://stackoverflow.com/questions/21046788/adding-node-to-existing-xml-element
            txtNum.Text = "";
            txtCodiArticle.Text = "";
            txtDescripcioArticle.Text = "";
            txtTalla.Text = "";
            txtColor.Text = "";
            txtPreu.Text = "";
            txtNum.Enabled = false;
            txtCodiArticle.Enabled = true;
            btnDoAltaXML.Enabled = true;
            btnCancelAltaXML.Enabled = true;
            btnAddXML.Enabled = false;
        }

        private void btnDoAltaXML_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Fer efectiva l'alta del node\n" +
                "BLOQUEJAR CODI D'ARTICLE\n" +
                "ACTIVAR I DESACTIVAR BUTTONS IGUAL QUE ES VA FER AMB LES ALTES EN BINARI" +
                "\nACTUANT SOBRE ELS BUTTONS ");
            Article unArticle = new Article(currentArticle.N, txtCodiArticle.Text, txtDescripcioArticle.Text,
                    double.Parse(txtPreu.Text), txtColor.Text, txtTalla.Text);
            bool afegit = xmlArticles.AddNode(unArticle);
            txtCodiArticle.Enabled = false;
            btnDoAltaXML.Enabled = false;
            btnCancelAltaXML.Enabled = false;
            if (afegit) MessageBox.Show("Afegit correctament.");
            else MessageBox.Show("No s'ha pogut afegir.");
        }

        private void btnCancelAltaXML_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Cancel·lar alta i deixar tot tal com estava abans d'iniciar el procés d'altes\n" +
                "BLOQUEJAR CODI D'ARTICLE\n" +
                "ACTIVAR I DESACTIVAR BUTTONS IGUAL QUE ES VA FER AMB LES ALTES EN BINARI" +
                "\nACTUANT SOBRE ELS BUTTONS");
            txtCodiArticle.Text = "";
            txtNum.Text = "";
            txtCodiArticle.Text = "";
            txtDescripcioArticle.Text = "";
            txtTalla.Text = "";
            txtColor.Text = "";
            txtPreu.Text = "";
            txtNum.Enabled = false;
            txtCodiArticle.Enabled = false;
            btnDoAltaXML.Enabled = false;
            btnCancelAltaXML.Enabled = false;
            btnAddXML.Enabled = true;
        }

        private void txtCodiArticle_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtDocumentXML_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtDescripcioArticle_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPreu_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtRegToGo_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
