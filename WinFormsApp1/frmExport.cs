using FitxersBinaris;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class frmExport : Form
    {
        private BinariArticles fArticles;
        public frmExport(BinariArticles f)
        {
            InitializeComponent();
            this.fArticles = f;
        }

        private void frmExport_Load(object sender, EventArgs e)
        {
           txtEnunciat.Text = "INTERFICIE ON ES PUGUI SELECCIONAR QUÈ S'HA D'EXPORTAR------" +
                "TOTS ELS CAMPS, O BÉ NOMÉS ALGUNS D'ELLS. CODI D'ARTICLE HA DE SER OBLIGATORI, LA RESTA OPCIONALS" +
                "----L'USUARI HA DE PODER TRIAR DESCRIPCIÓ, TALLA , COLOR , PREU" + "----I GENERAR UN .TXT ENCODING UTF-8 AMB TAMANY DE CAMP VARIABLE I DELIMITAT PER " +
                "---ELIMINANT ELS BLANCS DEL FINAL DELS CAMPS STRING";
                
        }

        private void txtEnunciat_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
