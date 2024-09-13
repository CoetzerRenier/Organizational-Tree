using System;
using System.Collections.ObjectModel;

namespace OrgianizationalTree
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create an organizational tree with a root node
            Tree<string> orgTree = new Tree<string>("CEO");

            // Add some nodes to the tree
            orgTree.AddNode("CEO", "CTO");
            orgTree.AddNode("CEO", "CFO");
            orgTree.AddNode("CTO", "Dev Manager");
            orgTree.AddNode("Dev Manager", "Developer");

            // Display the organizational tree structure
            orgTree.DisplayTree();
        }
    }
}
