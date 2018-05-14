namespace problemsolving.Trees
{
    public class TreeNode<T>
    {
        public T Value { get; set; }

        public bool Visited { get; set; }

        public TreeNode<T> Parent { get; set; }

        public TreeNode<T> Left { get; set; }

        public TreeNode<T> Right { get; set; }
    }
}
