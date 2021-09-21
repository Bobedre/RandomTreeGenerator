using System;
using System.Collections.Generic;
using System.Text;

namespace RandomTreeGenerator
{
    class Node
    {
        
        List<Node> Children = new List<Node>(); 
        int ChildrenForThisNode = 0;
        Node Parent = null;
        


        public Node(int MaxChildrenEachNode, Node Parent, int MaxDepth)
        {

            ChildrenForThisNode = CalculateChildren(MaxChildrenEachNode);

            for (int i = 0; i <= ChildrenForThisNode; i++)
            {
                Children[i] = new Node(MaxChildrenEachNode, this, MaxDepth);
                if (Children[i].GetDepth() > MaxDepth)
                {
                    break;
                }
                Console.WriteLine("NEW NODE!");
            }
        }

        private int CalculateChildren(int MaxChildrenEachNode)
        {
            Random rnd = new Random(); //STACK OVERFLOW!
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
            return depth;
        }
    }
}
