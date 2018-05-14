using System;
namespace problemsolving.LinkedList
{
    public class DeleteNode
    {
        public bool Delete(Node node)
        {
            if (node == null) return false;

            var next = node.Next;
            node.Value = next.Value;
            node.Next = next.Next;

            return true;
        }
    }
}
