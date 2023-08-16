using FitxersBinaris;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace WinFormsApp1
{
    public class SerialitzadorArticles
    {
        XmlSerializer serializer;
        StreamWriter writer;
        const string fileXMLOut = "articles.xml";
        public SerialitzadorArticles(String fileXMLOut)
        {

        }
        public bool SerialitzaUnArticle(Article a)
        {
            if (a.N != -1)
            {
                writer = new StreamWriter(fileXMLOut);
                serializer = new XmlSerializer(typeof(Article));
                serializer.Serialize(writer, a);
                writer.Close();
                return true;
            }
            else
            {
                return false;
                writer.Close();
            }
        }
        public int SerialitzaLlistaArticles(List<Article> articles)
        {
            writer = new StreamWriter(fileXMLOut);
            int count = 0;
            serializer = new XmlSerializer(articles.GetType(), new XmlRootAttribute("articles"));
            serializer.Serialize(writer.BaseStream, articles);
            count++;
            writer.Close();
            return count;
        }

    }
    
}
