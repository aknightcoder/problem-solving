namespace problemsolving.Trees
{
    public class LowestCommonAncestor
    {
        public int Find(TreeNode<int> root, int left, int right)
        {
            var ancestor = FindAncestor(root, left, right);

            return ancestor.Value;
        }

        private TreeNode<int> FindAncestor(TreeNode<int> node, int left, int right)
        {
            if (node == null) return null;

            if (node.Value == left || node.Value == right)
                return node;

            var leftCommonAncestor = FindAncestor(node.Left, left, right);

            var rightCommonAncestor = FindAncestor(node.Right, left, right);

            if (leftCommonAncestor != null && rightCommonAncestor != null)
                return node;

            return leftCommonAncestor ?? rightCommonAncestor;
        }
    }
}
