using System;
using System.Collections.Generic;

namespace problemsolving.Trees
{
    public class BalancedTree
    {
        public bool IsBalanced(TreeNode<int> node)
        {
            var stack = new Stack<TreeNode<int>>();

            stack.Push(node);

            while (stack.Count > 0)
            {
                var current = stack.Pop();

                if (!IsSubTreeBalanced(current))
                    return false;

                if (current.Left != null)
                    stack.Push(current.Left);

                if (current.Right != null)
                    stack.Push(current.Right);
            }

            return true;
        }

        private bool IsSubTreeBalanced(TreeNode<int> node)
        {
            int leftHeight = 0;

            int rightHeight = 0;

            var current = node;

            while (current.Left != null)
            {
                current = current.Left;
                leftHeight++;
            }

            current = node;
            while (current.Right != null)
            {
                current = current.Right;
                rightHeight++;
            }

            var delta = leftHeight - rightHeight;

            return Math.Abs(delta) <= 1;
        }
    }
}
