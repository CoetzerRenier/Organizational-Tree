using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrgianizationalTree
{
    internal class TreeNode
    {
        public string Name { get; set; }
        public TreeNode? Parent { get; private set; }

        public List<TreeNode> Children = new List<TreeNode>();

        public TreeNode(string name)
        {
            Name = name;
            Children = new List<TreeNode>();
        }

        public void AddChild(TreeNode child)
        {
            Children.Add(child);
        }

        public void PrintTree(string indent = "")
        {
            Console.WriteLine(indent + Name);
            foreach (var child in Children)
            {
                child.PrintTree(indent + "  ");
            }
        }
    }
}
