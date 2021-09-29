using System;
using System.Collections.Generic;
using System.Text;

namespace RandomTreeGenerator
{
    class ToolBox
    {
        public void DrawNode(Node RootNode)
        {
            int LocalDepth = RootNode.GetDepth(); //Figures out the depth for a specific note
            for (int i = 0; i < LocalDepth; i++)
            {
                Console.Write("    ");
            }
            Console.WriteLine("NODE" + RootNode.Content);
            foreach (var CurrentNode in RootNode.Children)
            {
                DrawNode(CurrentNode);
            }
        }

        //NOT FULLY FUNCTIONAL - WILL SOMETIMES THROW NullReferenceException
        public Node DepthFirstSearch(Node Rootnode, int Goal)
        {
            Stack<Node> NodesToLookIn = new Stack<Node>();
            NodesToLookIn.Push(RecursiveVisitor(Rootnode));

            foreach (var Node in NodesToLookIn)
            {
                //Console.WriteLine("CONTENT: " + Node.Content);
                if (Node.Content == Goal)
                {
                    return Node;
                }
            }
            return null;
        }

        private Node RecursiveVisitor(Node Node) //DOES NOT WORK YET!
        {
            foreach (var Child in Node.Children)
            {
                RecursiveVisitor(Child);
            }
            Console.WriteLine(Node.Content + "RETURNED");
            return Node;
        }
    }
}
