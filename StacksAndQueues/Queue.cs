namespace problemsolving.StacksAndQueues
{
    public class Queue<T>
    {
        private Node<T> _head;
        private Node<T> _tail;

        public void Enqueue(T Value)
        {
            var newNode = new Node<T>(Value, null);

            if (_head == null) 
            {
                _head = newNode;
                _tail = newNode;
            } 
            else 
            {
                _tail.Next = newNode;
                _tail = _tail.Next;
            }
        }

        public T Dequeue() 
        {
            if (_head == null) return default(T);

            var first = _head;

            _head = _head.Next;

            return first.Value;
        }
    }
}
