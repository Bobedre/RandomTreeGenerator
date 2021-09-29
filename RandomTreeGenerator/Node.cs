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
        Random rnd = new Random();
        public List<Node> Children = new List<Node>();
        public int Content = 0;

        public Node(int MaxChildrenEachNode, Node parent, int MaxDepth)
        {
            Parent = parent;
            ChildrenForThisNode = CalculateChildren(MaxChildrenEachNode);
            Content = CalculateContent();
            //Console.WriteLine("NODE HAS:" + ChildrenForThisNode + " CHILDREN"); -- FOR DEBUGGING
            if (GetDepth() == MaxDepth)
            {
                //  Console.WriteLine("DEPTH REACHED"); -- FOR DEBUGGING
                //Do nothing - Stop adding children
            }
            else
            {
                for (int i = 0; i < ChildrenForThisNode; i++)
                {
                    // Console.WriteLine("NEW NODE!"); -- FOR DEBUGGING
                    Children.Add(new Node(MaxChildrenEachNode, this, MaxDepth));
                    NumberOfNodesTotal++;
                }
                // Console.WriteLine("MAX CHILDREN REACHED"); -- FOR DEBUGGING
            }
        }

        private int CalculateContent()
        {
            int LocalContent;
            LocalContent = rnd.Next(0, 10);
            return LocalContent;
        }

        private int CalculateChildren(int MaxChildrenEachNode)
        {
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
