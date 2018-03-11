using System;
using System.Collections.Generic;
using System.Collections;

namespace task_4
{
    /// <summary>
    /// This class works on the elements of a tree    
    /// </summary>
    class TreeNode : IComparable<TreeNode>
    {
        public List<TreeNode> children;
        public List<string> attributes;
        TreeNode parent;
        
        public string tag;
        public string element;

        public TreeNode(TreeNode parent, string tag, string element)
        {
            this.parent = parent;
            this.tag = tag;
            this.element = element;
            this.children = new List<TreeNode>();
            this.attributes = new List<string>();
        }

        public TreeNode AddChild(string tag, string element)
        {
            TreeNode nodeItem = new TreeNode(this, tag, element);
            int index = children.IndexOf(nodeItem);
            children.Add(nodeItem);
            return nodeItem;
        }

        public void AddCAttributes(string value)
        {
            attributes.Add(value);
        }

        public TreeNode GetParent()
        {
            return parent;
        }

        public int CompareTo(TreeNode other)
        {
            int result = tag.CompareTo(other.tag);
            if (result == 0)
            {
                if (element != null && other.element != null)
                {
                    result = element.CompareTo(other.element);
                }
            }
            return result;
        }
    }
}
