namespace problemsolving.LinkedList
{
    public class FindLoopStart
    {
        public Node Find(Node node)
        {
            if (node == null) return node;

            var fast = node;
            var slow = node;

            while (fast != null && fast.Next != null)
            {
                slow = slow.Next;
                fast = fast.Next.Next;

                if (slow == fast)
                    break;
            }

            if (fast == null || fast.Next == null)
                return null;
            
            slow = node;

            while (slow != fast)
            {
                slow = slow.Next;
                fast = fast.Next;
            }

            return fast;
        }
    }
}
