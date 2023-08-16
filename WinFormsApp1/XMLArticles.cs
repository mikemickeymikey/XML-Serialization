using FitxersBinaris;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;

namespace WinFormsApp1
{
    public class XMLArticles
    {
        private XmlDocument doc;  //document de treball
        private XmlElement arrel; // arrel del document de treball
        private const string NOMFITXER = "articles.xml";
        public XMLArticles(String XMLFile)
        {
            doc = new XmlDocument();
            arrel = doc.DocumentElement;
        }
        /// <summary>
        /// Retorna el node de l'arbre XML associat al node que tingui codi 
        /// d'article = codiArticle
        /// </summary>
        /// <param name="codiArticle"></param>
        /// <returns>null si no el troba.</returns>
        private XmlNode GetNode(String codiArticle)
        {
             return doc.GetElementById(codiArticle);
        }
        public String TotElContingutXML()
        {
            doc.Load("articles.xml");
            arrel = doc.DocumentElement;
            return arrel.OuterXml;
        }
        /// <summary>
        /// Retorna l'article amb el codi donat, fent una consulta XPATH sobre
        /// el document xml actual
        /// </summary>
        /// <param name="CodiArticle"></param>
        /// <returns></returns>
        /// 
        public Article GetArticle(string CodiArticle)
        {
            Article unArticle = null;
            try
            {
                XmlNode article;
                article = arrel.SelectSingleNode("Article[Codi='" + CodiArticle + "']");
                if (article != null)
                {
                    unArticle = new Article(int.Parse(article.ChildNodes.Item(0).InnerText), article.ChildNodes.Item(1).InnerText,
                        article.ChildNodes.Item(2).InnerText, double.Parse(article.ChildNodes.Item(3).InnerText), article.ChildNodes.Item(4).InnerText,
                        article.ChildNodes.Item(5).InnerText);
                }
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("No s'ha trobat l'article.");
            }
            return unArticle;
        }
        /// <summary>
        /// /// Afegeix un article a al final del document (cal verificar si existeix)
        /// Si el codi existeix, no es pot donar d'alta
        /// Cal crear un nou node,
        /// Afegir-lo a l'arbre
        /// i no oblidar fer-lo persistent.
        /// </summary>
        /// <param name="a"></param>
        /// <returns>true si l'ha afegit, false si no ha pogut</returns>
        public bool AddNode(Article a)
        {
            bool afegit = false;
            if (doc != null)
            {
                XDocument doc = XDocument.Load(NOMFITXER);
                XElement root = new XElement("Article");
                root.Add(new XElement("Codi", a.Codi));
                root.Add(new XElement("Descripcio", a.Descripcio));
                root.Add(new XElement("Preu", a.Preu.ToString()));
                root.Add(new XElement("Color", a.Color));
                root.Add(new XElement("Talla", a.Talla));
                doc.Element("articles").Add(root);
                doc.Save(NOMFITXER);
                afegit = true;
            }
            return afegit;
        }
        /// <summary>
        /// /// Elimina l' article del document XML amb el codi = codiArticle
        /// Si el codi no existeix, no es pot eliminar
        /// Cal eliminar el node,
        /// i no oblidar fer persistents els canvis
        
        /// </summary>
        /// <param name="codiArticle"></param>
        /// <returns>true si l'ha eliminat, false si no ha pogut</returns>
        public bool DeleteNode(String codiArticle)
        {
            bool trobatEliminat = false;
            XDocument doc1 = XDocument.Load(NOMFITXER);
            XElement node = (from xml in doc1.Descendants("Article")
                             where xml.Element("Codi").Value == codiArticle
                             select xml).FirstOrDefault();
            if(node != null)
            {
                node.Remove();
                doc1.Save(NOMFITXER);
                trobatEliminat = true;
            }
            /*XmlDocument doc = new XmlDocument();
            doc.Load(NOMFITXER);
            XmlElement arrel = doc.DocumentElement;
            XmlNode article = arrel.SelectSingleNode("Article[Codi='" + codiArticle + "']");
            if (article != null)
            {
                article.ParentNode.RemoveChild(article);
                doc.Save(NOMFITXER);
                trobatEliminat = true;
            }*/
            return trobatEliminat;
        }
        /// <summary>
        /// Cerca el node amb el codi d'article = codiArticle
        /// Actualitza tots els continguts dels subnodes
        /// /// i no oblidar fer persistents els canvis
        /// </summary>
        /// <param name="codiArticle"></param>
        /// <returns>true si s'ha trobat l'article i s'ha actualitzat</returns>
        public bool UpdateNode(Article unArticle)
        {
            bool trobatActualitzat = false;
            XmlDocument doc = new XmlDocument();
            doc.Load(NOMFITXER);
            XmlElement arrel = doc.DocumentElement;
            XmlNode article = arrel.SelectSingleNode("Article[Codi='" + unArticle.Codi + "']");
            if (article != null)
            {
                article.ChildNodes.Item(2).InnerText = unArticle.Descripcio;
                article.ChildNodes.Item(3).InnerText = unArticle.Preu.ToString();
                article.ChildNodes.Item(4).InnerText = unArticle.Color;
                article.ChildNodes.Item(5).InnerText = unArticle.Talla;
                trobatActualitzat = true;
                doc.Save(NOMFITXER);
            }
            return trobatActualitzat;
        }
    }
}
