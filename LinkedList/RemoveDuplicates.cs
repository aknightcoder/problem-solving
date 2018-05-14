using System.Collections.Generic;

namespace problemsolving.LinkedList
{
    public class RemoveDuplicates
    {
        public ComparableNode Remove(ComparableNode node)
        {
            var existingNodes = new Dictionary<int, bool>();

            var head = node;
            var previous = node;

            while (node != null)
            {
                if (existingNodes.ContainsKey(node.Value))
                {
                    previous.Next = node.Next;
                }
                else 
                {
                    existingNodes.Add(node.Value, true);
                }

                previous = node;
                node = node.Next;
            }

            return head;
        }

        public ComparableNode RemoveWithRunner(ComparableNode node)
        {
            var slow = node;
            var fast = node;

            while (slow != null)
            {
                var previous = slow;

                while (fast != null) 
                {
                    if (slow.CompareTo(fast) == 0)
                    {
                        previous.Next = fast.Next;
                    }
                    else
                    {
                        previous = fast;
                    }

                    fast = fast.Next;
                }

                slow = slow.Next;

                if (slow != null)
                    fast = fast.Next;
            }

            return node;
        }
    }
}
