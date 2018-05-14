using System;
using System.Collections.Generic;

namespace problemsolving.StacksAndQueues
{
    public class CustomStack<T> where T : IComparable
    {
        private LinkedList<Node<T>> _min;

        private int _size;

        private Node<T> _top;

        public CustomStack()
        {
            _size = 0;

            _min = new LinkedList<Node<T>>();
        }

        public bool IsEmpty()
        {
            return _size == 0;
        }

        public T Min(){
           
            return _min.Last.Value.Value;
        }

        public T Peek() 
        {
            return _top == null ? default(T) : _top.Value;
        }

        public void Push(T value)
        {
            var newNode = new Node<T>(value);

            if (_min.Count > 0 || newNode.Value.CompareTo(_min.Last) < 0)
                _min.AddLast(newNode);

            if (_top == null) {
                _top = newNode;
            }
            else {
                var oldTop = _top;
                _top = newNode;
                _top.Next = oldTop;
            }
        }

        public T Pop(){

            if (_top == null) return default(T);

            var last = _top;

            _size--;

            if (last.Value.CompareTo(_min.Last.Value) == 0)
                _min.RemoveLast();

            return last.Value;
        }

        public int Count()
        {
            return _size;
        }
    }
}
