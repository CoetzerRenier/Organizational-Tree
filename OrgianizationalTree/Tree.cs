using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrgianizationalTree
{
    internal class Tree<T>
    {
        public TreeNode Root { get; private set; }

        List<TreeNode> root = new List<TreeNode>();

        public Tree(string rootName)
        {
            Root = new TreeNode(rootName);
        }

        public void AddNode(string parentName, string childName)
        {
            TreeNode parentNode = FindNode(Root, parentName);
            if (parentNode != null)
            {
                parentNode.AddChild(new TreeNode(childName));
            }
            else
            {
                Console.WriteLine("Parent not found.");
            }
        }

        private TreeNode FindNode(TreeNode currentNode, string name)
        {
            if (currentNode.Name == name)
            {
                return currentNode;
            }

            foreach (var child in currentNode.Children)
            {
                TreeNode result = FindNode(child, name);
                if (result != null)
                {
                    return result;
                }
            }
            return null;
        }

        public void DisplayTree()
        {
            if (Root != null)
            {
                Root.PrintTree();
            }
        }
    }
}
