using System.Collections.Generic;

namespace problemsolving.Trees
{
    public class BinaryTreeToLinkLists
    {
        public List<LinkedList<TreeNode<int>>> Convert(TreeNode<int> tree)
        {
            var resultList = new List<LinkedList<TreeNode<int>>>();

            var current = new LinkedList<TreeNode<int>>();

            if (tree != null){
                current.AddLast(tree);
            }

            while (current.Count > 0)
            {
                resultList.Add(current);

                var parents = current;

                var currentList = new LinkedList<TreeNode<int>>();

                foreach (var parent in parents)
                {
                    if (parent.Left != null)
                    {
                        currentList.AddLast(parent.Left);
                    }

                    if (parent.Right != null)
                    {
                        currentList.AddLast(parent.Right);
                    }
                }

                current = currentList;
            }

            return resultList;
        }
    }
}
