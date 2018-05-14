using System;
namespace problemsolving.LinkedList
{
    public class ComparableNode : IComparable<ComparableNode>
    {
        public int Value { get; set; }

        public ComparableNode Next { get; set; }

        public ComparableNode(int value, ComparableNode node = null)
        {
            Value = value;
            Next = node;
        }

        public int CompareTo(ComparableNode other)
        {
            if (Value == other.Value) return 0;

            return Value > other.Value ? -1 : 1;
        }
    }
}
