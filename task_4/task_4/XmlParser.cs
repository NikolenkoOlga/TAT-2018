using System;
using System.Collections.Generic;
using System.IO;

namespace task_4
{
    /// <summary>
    /// Class's for parsing XML files
    /// </summary>
    class XmlParser
    {
        public enum ItemTypes
        {
            OpenTag,
            CloseTag,
            ToSkip,
            Undefined
        }

        public class ParsedItem
        {
            public ItemTypes types;
            public string tag;
            public string element;
            public List<string> attr;
        }

        private string fileName;
        private TreeNode root;

        public XmlParser(string fileName, TreeNode root)
        {
            this.fileName = fileName;
            this.root = root;
        }

        public ParsedItem FindItem(string s)
        {
            ParsedItem result = new ParsedItem();
            int startTag = s.IndexOf('<') + 1;
            if (s[startTag] == '?')
            {
                result.types = ItemTypes.ToSkip;
            }
            else if (s[startTag] == '/')
            {
                result.types = ItemTypes.CloseTag;
            }
            else
            {
                result.types = ItemTypes.OpenTag;

                int closingBPos = s.IndexOf('>');
                int endTag = s.IndexOf(' ', startTag, closingBPos - startTag + 1);
                if (endTag < 0)
                {
                    endTag = closingBPos - 1;
                }
                else
                {
                    string attrStr = s.Substring(endTag + 1, closingBPos - 1 - endTag);
                    string[] attributes = attrStr.Split(" ".ToCharArray());
                    if (attributes.Length > 0)
                    {
                        result.attr = new List<string>();
                        foreach (string a in attributes)
                        {
                            result.attr.Add(a.Replace('=', '-'));
                        }
                    }
                }
                result.tag = s.Substring(startTag, endTag - startTag + 1).Trim();

                string rest = s.Substring(closingBPos + 1).Trim();
                int startNextTag = rest.IndexOf('<');
                if (startNextTag > 0)
                {
                    result.element = rest.Substring(0, startNextTag);
                }
            }
            return result;
        }

        public void Parse()
        {
            StreamReader streamReader = new StreamReader(fileName);
            string xmlLines = streamReader.ReadToEnd();
            TreeNode currentNode = root;
            while (xmlLines.Length > 0)
            {
                ParsedItem parsedItem = FindItem(xmlLines);
                switch (parsedItem.types)
                {
                    case ItemTypes.OpenTag:
                        currentNode = currentNode.AddChild(parsedItem.tag, parsedItem.element, parsedItem.attr);
                        break;

                    case ItemTypes.CloseTag:
                        currentNode = currentNode.GetParent();
                        break;

                    case ItemTypes.ToSkip:
                        break;
                }
                int nextTag = xmlLines.IndexOf('<', 1);
                if (nextTag < 0)
                {
                    break;
                }
                xmlLines = xmlLines.Substring(nextTag);
            }
        }
    }
}
