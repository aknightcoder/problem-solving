namespace problemsolving.LinkedList
{
    public class MergeNodeList
    {
        public ComparableNode Merge(ComparableNode left, ComparableNode right)
        {
            var head = new ComparableNode(0);

            var current = head;

            while (left != null && right != null) 
            {
                if (left == null || right == null)
                {
                    current.Next = right ?? left;
                    break;
                }

                if (left.CompareTo(right) == -1)
                {
                    current.Next = left;
                    left = left.Next;
                }
                else 
                {
                    current.Next = right;
                    right = right.Next;
                }
            }

            return head;
        }
    }
}
