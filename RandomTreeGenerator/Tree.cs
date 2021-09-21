using System;
using System.Collections.Generic;
using System.Text;

namespace RandomTreeGenerator
{
    class Tree
    {
        Random rnd = new Random();
        public int TreeDepth;
        public int ChildrenEachNode;

        public Tree(Node rootNode, int treeDepth, int childrenEachNode)
        {
            TreeDepth = treeDepth;
            ChildrenEachNode = childrenEachNode;
        }
    }
}
