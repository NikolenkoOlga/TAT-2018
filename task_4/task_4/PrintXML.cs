using System;
using System.Collections.Generic;

namespace task_4
{
    /// <summary>
    /// This class prints XML file data to the console
    /// </summary>
    class PrintXML
    {
        public TreeNode root;
        public PrintXML(TreeNode root)
        {
            this.root = root;
        }
        
        public void PrintChild(TreeNode node, string path)
        {
            Console.WriteLine("{0}-{1}", path, node.tag);
            path += "-" + node.tag;
            if (node.element != null)
            {
                Console.WriteLine("{0}-{1}", path, node.element);
            }

            node.attributes.Sort();
            for (int i = 0; i < node.attributes.Count; i++)
            {
                Console.WriteLine("{0}-{1}", path, node.attributes[i]);
            }

            node.children.Sort();
            for (int i = 0; i < node.children.Count; i++)
            {
                PrintChild(node.children[i], path);
            }
        }

        public void Print()
        {
            PrintChild(root, "");
        }
    }
}
