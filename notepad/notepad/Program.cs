using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace notepad
{
    class Program
    {
        static void Main(string[] args)
        {
            InitializeXML();
            OptionsMenu();
        }

        /// <summary>
        /// Checks if XML exists, if it doesn't it creates a new file
        /// </summary>
        static void InitializeXML()
        {
            if(!System.IO.File.Exists("notes.xml"))
            {
                XmlWriter xmlWriter = XmlWriter.Create("notes.xml");
                xmlWriter.WriteStartDocument();
                xmlWriter.WriteStartElement("notes");
                xmlWriter.Close();
            }
        }

        /// <summary>
        /// Lists every user option and handles it
        /// </summary>
        static void OptionsMenu()
        {
            Console.Clear();

            while (true)
            {
                Console.WriteLine("1. Loe märkmeid");
                Console.WriteLine("2. Kirjuta märge");
                Console.WriteLine("3. Välju");

                string userInput = Console.ReadLine();

                switch(userInput)
                {
                    case "1":
                        XMLRead.ListNotes();
                        break;
                    case "2":
                        XMLWrite.WriteNote();
                        break;
                    case "3":
                        return;
                    default:
                        Console.WriteLine("Tundmatu käsk");
                        break;
                }
            }
        }
    }
}
