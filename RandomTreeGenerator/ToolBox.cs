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


        //NOT FULLY FUNCTIONAL YET!
        public Node DepthFirstSearch(Node Rootnode, int Goal)
        {
            
            Stack<Node> frontier = new Stack<Node>();
            frontier.Push(Rootnode);
            while (frontier != null)
            { 
                foreach (var node in frontier)
                {
                    Console.WriteLine("IN STACK: " + node.Content);
                    if (node.Content == Goal)
                    {
                        Console.WriteLine("Goal node found!");
                        return node;
                    }
                    else
                    {
                        foreach (var children in node.Children)
                        {
                            frontier.Push(children);
                        }
                    }
                }
                frontier.Pop(); //POPS TOP - NEED TO REMOVE ALREADY LOOKED AT NODE
            }
            Console.WriteLine("No goal node!");
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
