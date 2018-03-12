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

        // current item in the tree
        public string tag;
        public string element;

        public TreeNode(TreeNode parent, string tag, string element, List<string> attributes)
        {
            this.parent = parent;
            this.tag = tag;
            this.element = element;
            this.attributes = attributes;
            this.children = new List<TreeNode>();
        }

        public TreeNode AddChild(string tag, string element, List<string> attributes)
        {
            TreeNode nodeItem = new TreeNode(this, tag, element, attributes);
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
