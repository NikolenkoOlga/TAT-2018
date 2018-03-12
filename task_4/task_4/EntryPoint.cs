using System;
using System.IO;
using System.Collections;

namespace task_4
{
    class EntryPoint
    {
        static void Main(string[] args)
        {
            // InputOutputXML inputOutputXML = new InputOutputXML(args[0]);
            TreeNode root = new TreeNode(null, null, null, null);
            XmlParser xmlParser = new XmlParser(args[0],root);
            xmlParser.Parse();
            PrintXML printXML = new PrintXML(root);
            printXML.Print();
        }
    }
}
