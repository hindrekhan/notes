using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace notepad
{
    /// <summary>
    /// Used for reading notes
    /// </summary>
    class XMLRead
    {
        /// <summary>
        /// Lists every note and handles user input
        /// </summary>
        public static void ListNotes()
        {
            Console.Clear();

            XmlDocument doc = new XmlDocument();
            doc.Load("notes.xml");
            var rootNode = doc.DocumentElement;

            if (rootNode.ChildNodes.Count == 0)
            {
                Console.WriteLine("Pole märkmeid\n");
                return;
            }

            for (int i = 0; i < rootNode.ChildNodes.Count; i++)
                Console.WriteLine((i + 1) + ". " + rootNode.ChildNodes[i].Attributes["name"].Value);

            int userOption = Int32.Parse(Console.ReadLine());

            Console.Clear();

            if (!(userOption > 0 && userOption <= rootNode.ChildNodes.Count))
                return;

            Console.WriteLine(rootNode.ChildNodes[userOption - 1].Attributes["text"].Value);
            Console.WriteLine();
        }
    }
}
