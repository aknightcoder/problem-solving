namespace problemsolving.Trees
{
    public class FindSuccessor
    {
        public TreeNode<int> Find(TreeNode<int> node)
        {
            if (node == null) return null;

            if (node.Right != null)
            {
                return GetLeftModeNode(node.Right);
            }

            var parent = node.Parent;

            while (node != null && node != parent.Left)
            {
                node = parent;

                parent = node.Parent;
            }

            return parent;
        }

        private TreeNode<int> GetLeftModeNode(TreeNode<int> node){

            while (node.Left != null){
                node = node.Left;
            }

            return node;
        }
    }
}
