using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace FitxersBinaris
{
    public class Article
    {
        private int n; //4 bytes
        private string codi;// longitud 13. Fins 12 caràcters comptant blancs + null
        private string descripcio; // longitud 101.Fins 100 caràcters comptant blancs + null
        private double preu;  //8 bytes 
        private string color;// longitud 30. Fins 29 caràcters comptant blancs + null
        private string talla; // longitud 19. Fins 18 caràcters comptant blancs + null
        /// <summary>
        /// Crea un article amb els atributs associats als paràmetres
        /// però cada paràmetre string cal completar amb blancs per assolir longitud fixa
        /// </summary>
        /// <param name="n"></param>
        /// <param name="codi"></param>
        /// <param name="descripcio"></param>
        /// <param name="preu"></param>
        /// <param name="color"></param>
        /// <param name="talla"></param>
        public Article(int n, string codi, string descripcio, double preu, string color, string talla)
        {
            this.n = n;
            this.codi = AjustarTamany(codi,12);
            //MessageBox.Show("CODI "+ codi.Length.ToString());
            this.descripcio = AjustarTamany(descripcio,100);
            //MessageBox.Show("DESCRIPCIO "+ descripcio.Length.ToString());
            this.preu = preu;
            this.color = AjustarTamany(color,29);
            //MessageBox.Show("COLOR "+color.Length.ToString());
            this.talla = AjustarTamany(talla, 18);
            //MessageBox.Show("TALLA "+talla.Length.ToString());
        }

        public Article()
        {

        }

        [XmlIgnoreAttribute]
        public int N { get => n; set => n = value; }
        public string Codi { get => codi; 
            set
            {
                codi=AjustarTamany(value, 12);
            }
        }
        public string Descripcio
        {
            get => descripcio; 
            set
            {
                descripcio = AjustarTamany(value, 100);
            }
        }
        public double Preu { get => preu; set => preu = value; }
        public string Color { get => color;
            set
            {
                color = AjustarTamany(value, 29);
            }
        }
        public string Talla { get => talla;
            set
            {
                talla = AjustarTamany(value, 18);
            }
        }
        /// <summary>
        /// Completa l'string amb blancs fins la longitud marcada
        /// </summary>
        /// <param name="camp"></param>
        /// <param name="longitud"></param>
        /// <returns></returns>
        private string AjustarTamany(string camp, int longitud)
        {
            string resultat;
            if (camp.Length > longitud)
                resultat = camp.Substring(0, longitud);
            else
                resultat = camp.PadRight(longitud);
            return resultat;
        }
    }
}
