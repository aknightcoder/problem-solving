namespace problemsolving.LinkedList
{
    public static class Utils
    {
        public static int GetLength(Node node) {
            int length = 0;

            while (node != null){
                length++;
                node = node.Next;
            }

            return length;
        }

        public static Node AddBefore(Node nodeToAdd, Node existingNode) {
            if (nodeToAdd == null && existingNode == null) return null;

            if (nodeToAdd == null) return existingNode;

            nodeToAdd.Next = existingNode;

            return nodeToAdd;
        }

        public static Node AddPadding(Node node, int padLength) {

            if (node == null) return null;

            var lastNode = GetLast(node);

            for (int i = 1; i <= padLength; i++){
                lastNode.Next = new Node(0, null);
            }

            return node;
        }

        public static Node GetLast(Node node){
            
            while (node.Next != null)
            {
                node = node.Next;
            }

            return node;
        }
    }
}
