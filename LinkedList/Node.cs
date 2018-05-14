namespace problemsolving.LinkedList
{
    public class Node
    {
        public int Value { get; set; }

        public Node Next { get; set; }

        public Node(int value, Node node){
            Value = value;
            Next = node;
        }
    }
}
