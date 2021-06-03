using System;
using System.Xml.Linq;
using System.IO;

namespace _8Bot_Configuration.Controller
{
    public class UseXML
    {
        //faz todo o processo de load ou criação do xml
        public readonly static string directory = string.Format
        (
            @"{0}\Database\", 
            LocalObserver.GetDirectoryOfApp()
        );

        public static XDocument Xml { get; set; }

        public static bool CheckifXMLExist()
        {
            if (Directory.Exists(directory))
            {
                Xml = XDocument.Load(directory + @"\Database.xml");
                return true;
            }
            return false;
        }

        public static void CreateDatabase(string nameOfirstElement)
        {
            Directory.CreateDirectory(directory);
            Console.WriteLine("Database dont't exist. Creating...");

            XDocument x = new XDocument
                (
                    new XDeclaration("1.0", "UTF-16", "yes"),
                    new XElement("Database",
                        new XElement(nameOfirstElement))
                );
            
            SaveDatabase(x);
            Xml = x;
        }

        public static void SaveDatabase(XDocument xml)
        {
            xml.Save(directory + "Database.xml");
        }
    }
}
