using System;
using System.Collections.Generic;
using System.Text;

namespace RandomTreeGenerator
{
    class Node
    {

        public static int NumberOfNodesTotal = 1;
        int ChildrenForThisNode = 0;
        Node Parent = null;
        public List<Node> Children = new List<Node>();  


        public Node(int MaxChildrenEachNode, Node parent, int MaxDepth)
        {
            Parent = parent;
            ChildrenForThisNode = CalculateChildren(MaxChildrenEachNode);
            //Console.WriteLine("NODE HAS:" + ChildrenForThisNode + " CHILDREN");
            if (GetDepth() == MaxDepth)
            {
               //  Console.WriteLine("DEPTH REACHED");
                //Do nothing - Stop adding children
            }
            else
            {
                for (int i = 0; i < ChildrenForThisNode; i++)
                {
                    // Console.WriteLine("NEW NODE!");
                    Children.Add(new Node(MaxChildrenEachNode, this, MaxDepth));
                    NumberOfNodesTotal++;
                }
                // Console.WriteLine("MAX CHILDREN REACHED");
            }
        }

        private int CalculateChildren(int MaxChildrenEachNode)
        {
            Random rnd = new Random(); 
            ChildrenForThisNode = rnd.Next(0, MaxChildrenEachNode);
            return ChildrenForThisNode;
        }

        public int GetDepth()
        {
            int depth = 0;
            Node CurrentNode = this;
            while (CurrentNode.Parent != null)
            {
                depth++;
                CurrentNode = CurrentNode.Parent;
            }
            //Console.WriteLine("Depth:" + depth); -- FOR DEBUGGING
            return depth;
        }
    }
}
