using System;
using Xunit;
using RandomTreeGenerator;
using System.Collections.Generic;

namespace XunitTests
{
    public class GetDepth
    {
        [Fact]
        public void CheckGetDepth()
        {
            //Arrange
            ToolBox toolbox = new ToolBox();
            List<Node> listOfChildren = new List<Node>();
            int maxDepthInTree = 0;

            //Act -- With maxDepth = 3 
            Node Tree = new Node(3,null, 3);
            foreach (var child in Tree.Children)
            {
                listOfChildren.Add(toolbox.RecursiveVisitor(child));
            }

            foreach (var node in listOfChildren)
            {
                if (node.GetDepth() > maxDepthInTree)
                {
                    maxDepthInTree = node.GetDepth();
                }
            }

            //Assert
            Assert.InRange(maxDepthInTree, 0, 3);
        }
    }
}
