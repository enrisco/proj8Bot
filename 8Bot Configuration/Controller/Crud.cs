using System;
using System.Linq;
using _8Bot_Configuration.Model;
using System.Xml.Linq;

namespace _8Bot_Configuration.Controller
{
    public class Crud
    {
        static XDocument Xml { get; set; }

        public static void Create(Settings setting)
        {
            Xml = UseXML.Xml;

            Xml.Element("Database").Element("Settings").Add
                (
                    new XElement
                    (
                        "setting",
                        new XAttribute("name", setting.name),
                        new XAttribute("path", setting.path)
                    )
                );

            Console.WriteLine("Element '{0}' saved.", setting.name);
            UseXML.SaveDatabase(Xml);
        }

        /*public static string[] Read()
        {
            Xml = UseXML.Xml;

            var query = Xml.Descendants("Game").Select(s => (string)s.Attribute("name"));
            return query.ToArray();
        }*/

        /*public static Game Read(string gameName)
        {
            Game game = new Game();
            Xml = UseXML.Xml;

            var query = from p in Xml.Descendants("Game")
                           where (string)p.Attribute("name") == gameName
                           select p;

            foreach (var record in query)
            {
                game.Name = record.Attribute("name").Value.ToString();
                game.Deaths = (int)record.Attribute("deaths");
            }

            return game;
        }*/

        public static void Update(Settings setting)
        {
            Xml = UseXML.Xml;

            var _setting = from p in Xml.Descendants("setting")
                           where (string)p.Attribute("name") == setting.name
                           select p;
            
            foreach(XElement e in _setting)
                e.SetAttributeValue("path", setting.path);
            UseXML.SaveDatabase(Xml);
            Console.WriteLine("Item Uploaded.");
        }
    }
}
