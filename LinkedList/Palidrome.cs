using System.Collections.Generic;

namespace problemsolving.LinkedList
{
    public class Palidrome
    {
        public bool IsPalidrome(Node node)
        {
            if (node == null) return false;

            Stack<Node> stack = new Stack<Node>();

            var fast = node;
            var slow = node;
            while (fast != null  && fast.Next != null)
            {
                stack.Push(slow);

                fast = fast.Next.Next;
                slow = slow.Next;
            }

            if (fast != null) slow = slow.Next;

            Node left = null;
            while(slow != null){

                left = stack.Pop();

                if (left.Value != slow.Value)
                    return false;
                
                slow = slow.Next;
            }

            return true;
        }
    }
}
