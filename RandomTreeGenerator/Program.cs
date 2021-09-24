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
            
            Console.WriteLine(Node.NumberOfNodesTotal);
        }
    }
}
