namespace problemsolving.Trees
{
    public class IsBinarySearchTree
    {
        public bool Validate(TreeNode<int> node)
        {
            return IsBst(node);
        }

        private bool IsBst(TreeNode<int> node, int? min = null, int? max = null)
        {
            if (node == null) return true;

            if (min.HasValue && node.Value < min || max.HasValue && node.Value > max)
                return false;

            if (IsBst(node.Left, min, node.Value) || IsBst(node.Right, node.Value, max))
                return false;
            
            return true;
        }
    }
}
