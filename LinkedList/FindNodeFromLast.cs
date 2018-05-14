namespace problemsolving.LinkedList
{
    public class FindNodeFromLast
    {
        public Node Find(Node node, int k)
        {
            Node fast = null;

            for (int i = 0; i < k; i++){
                fast = node.Next;
            }

            while (fast.Next != null){

                node = node.Next;
                
                fast = fast.Next;
            }

            return node;
        }
    }
}
