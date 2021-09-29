using System;

namespace RandomTreeGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            TreeGenerator Test = new TreeGenerator();
            ToolBox toolbox = new ToolBox();
            Node Tree = Test.Start();
            toolbox.DrawNode(Tree);
            Console.WriteLine(Node.NumberOfNodesTotal); //Prints total number of nodes in the tree

            try
            {
                Node DfsResult = toolbox.DepthFirstSearch(Tree, 5);
                Console.WriteLine("Depth of goal node: " + DfsResult.GetDepth());
            }
            catch(Exception exception)
            {
                Console.WriteLine("\n" + exception);
            }
        }
    }
}
