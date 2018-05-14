using System;

namespace problemsolving.Trees
{
    public class MinimalBST
    {
        public TreeNode<int> CreateMinimalBST(int[] array)
        {
            return CreateNode(array, 0, array.Length - 1);
        }

        private TreeNode<int> CreateNode(int[] array, int start, int end)
        {
            if (end < start){
                Console.WriteLine("returns {0}-{1}", start, end);
                return null;
            } 

            var midIndex = (start + end) / 2;

            Console.WriteLine("{0}-{1}-{2}", start, end, midIndex);

            var node = new TreeNode<int>
            {
                Value = array[midIndex],

                Left = CreateNode(array, start, midIndex - 1),

                Right = CreateNode(array, midIndex + 1, end)
            };

            return node;
        }
    }
}
