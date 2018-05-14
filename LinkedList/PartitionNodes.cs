using problemsolving.StacksAndQueues;

namespace problemsolving.LinkedList
{
    public class PartitionNodes<T>
    {
        public ComparableNode Partition(ComparableNode node, ComparableNode pivotNode)
        {
            if (node == null) return null;

            ComparableNode leftBegin = null;
            ComparableNode leftEnd = null;
            ComparableNode rightBegin = null;
            ComparableNode rightEnd = null;

            while(node != null)
            {
                if (node.CompareTo(pivotNode) == 0)
                {
                    if (leftBegin == null)
                    {
                        leftBegin = node;
                        leftEnd = leftBegin;
                    }
                    else
                    {
                        leftEnd.Next = node;
                        leftEnd = leftEnd.Next;
                    }
                }
                else 
                {
                    if (rightBegin == null)
                    {
                        rightBegin = node;
                        rightEnd = rightBegin;
                    }
                    else
                    {
                        rightEnd.Next = node;
                        rightEnd = rightEnd.Next;
                    }
                }

                node = node.Next;
            }

            if (leftEnd != null) 
                leftEnd.Next = null;

            if (rightEnd != null)
                rightEnd.Next = null;

            if (leftBegin == null && rightBegin != null)
                return rightBegin;

            if (rightBegin == null)
                return leftBegin;

            leftEnd.Next = rightBegin;

            return leftBegin;
        }
    }
}
