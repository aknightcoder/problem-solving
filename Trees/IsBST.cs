using System;
using System.Collections.Generic;
using msCollections = System.Collections.Generic;

namespace problemsolving.Trees
{
    public class IsBinarySearchTree
    {
        public bool Validate(TreeNode<int> tree)
        {
            var isBinarySearchTree = true;

            var queue = new Queue<TreeNode<int>>();

            queue.Enqueue(tree);

            while (queue.Count > 0) 
            {
                var current = queue.Dequeue();

                if (current.Left != null)
                {
                    if (current.Left.Value > current.Value)
                    {
                        isBinarySearchTree = false;
                        break;
                    }

                    queue.Enqueue(current.Left);
                }

                if (current.Right != null)
                {
                    if (current.Right.Value < current.Value)
                    {
                        isBinarySearchTree = false;
                        break;
                    }

                    queue.Enqueue(current.Right);
                }
            }

            return isBinarySearchTree;
        }
    }
}
