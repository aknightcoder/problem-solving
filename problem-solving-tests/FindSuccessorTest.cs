using NUnit.Framework;
using problemsolving.Trees;

namespace problemsolvingtests
{
    public class FindSuccessoTest
    {
        [Test()]
        public void FindSucccessorTest()
        {
            var rootNode = new TreeNode<int> { Value = 5 };

            var fourNode = new TreeNode<int> { Value = 4 };

            var threeNode = new TreeNode<int>
            {
                Value = 3,
                Right = fourNode
            };

            rootNode.Left = threeNode;

            fourNode.Parent = threeNode;

            threeNode.Parent = rootNode;

            var sixNode = new TreeNode<int> { Value = 6 };

            var sevenNode = new TreeNode<int> { Value = 7};

            sevenNode.Left = sixNode;

            sixNode.Parent = sevenNode;

            rootNode.Right = sevenNode;

            var findSuccessor = new FindSuccessor();

            var successorNode = findSuccessor.Find(sixNode);

            Assert.AreEqual(7, successorNode.Value);


            successorNode = findSuccessor.Find(fourNode);

            Assert.AreEqual(5, successorNode.Value);


            successorNode = findSuccessor.Find(rootNode);

            Assert.AreEqual(6, successorNode.Value);
        }
    }
}
