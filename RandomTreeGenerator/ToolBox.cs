using System;
using System.Collections.Generic;
using System.Text;

namespace RandomTreeGenerator
{
    class ToolBox
    {
        public void DrawNode(Node RootNode)
        {
            int LocalDepth = RootNode.GetDepth();
            for (int i = 0; i < LocalDepth; i++)
            {
                Console.Write("   ");
            }
            Console.WriteLine("NODE");
            foreach (var CurrentNode in RootNode.Children)
            {
                DrawNode(CurrentNode);
            }
        }
    }
}
