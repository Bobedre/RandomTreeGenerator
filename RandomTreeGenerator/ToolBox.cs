using System;
using System.Collections.Generic;
using System.Text;

namespace RandomTreeGenerator
{
    public class ToolBox
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

            //NEEDS TO HAPPEN IN A LOOP UNTIL ?? 
            NodesToLookIn.Push(RecursiveVisitor(Rootnode));
            

            

            foreach (var Node in NodesToLookIn)
            {
                Console.WriteLine("IN STACK: " + Node.Content);
                if (Node.Content == Goal)
                {
                    return Node;
                }
            }
            return null;
        }

        public Node RecursiveVisitor(Node Node)
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
