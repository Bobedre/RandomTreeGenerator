using System;
using System.Collections.Generic;
using System.Text;

namespace RandomTreeGenerator
{
    class TreeGenerator
    {
        int TreeDepth = 0;
        int ChildrenEachNode = 0;
        string respons = "";


        public Node Start()
        {
            Console.WriteLine("How deep do you want the tree?");
            respons = Console.ReadLine();
            int.TryParse(respons, out TreeDepth);
            Console.WriteLine("Max number of children for each node?");
            respons = Console.ReadLine();
            int.TryParse(respons, out ChildrenEachNode);

            Node FinalTree = TreeGeneratorMethod(TreeDepth, ChildrenEachNode);
            return FinalTree;
        }

        private Node TreeGeneratorMethod(int TreeDepth, int MaxChildrenEachNode)
        {
            Node RootNode = new Node(MaxChildrenEachNode, null, TreeDepth);
            Console.WriteLine("DONE");
            return RootNode;
        }
    }
}
