using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace notepad
{
    /// <summary>
    /// Used to write notes
    /// </summary>
    class XMLWrite
    {
        /// <summary>
        /// Asks for header and text and appends to XML file
        /// </summary>
        public static void WriteNote()
        {
            Console.Clear();
            Console.WriteLine("Pealkiri:");
            string Name = Console.ReadLine();
            Console.WriteLine("Tekst:");
            string Text = Console.ReadLine();

            XmlDocument doc = new XmlDocument();
            doc.Load("notes.xml");
            XmlElement newNote = doc.CreateElement("note");
            newNote.SetAttribute("name", Name);
            newNote.SetAttribute("text", Text);

            XmlNode rootNode = doc.DocumentElement;
            rootNode.AppendChild(newNote);

            doc.Save("notes.xml");

            Console.Clear();
            Console.WriteLine("Märge loodud\n");
        }
    }
}
