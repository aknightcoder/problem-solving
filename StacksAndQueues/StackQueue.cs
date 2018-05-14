using msCollections = System.Collections.Generic;

namespace problemsolving.StacksAndQueues
{
    public class StackQueue<T>
    {
        private msCollections.Stack<T> _stackOne;
        private msCollections.Stack<T> _stackTwo;

        public StackQueue()
        {
            _stackOne = new msCollections.Stack<T>();

            _stackTwo = new msCollections.Stack<T>();
        }

        public void Enqueue(T value){
            
            _stackOne.Push(value);
        }

        public T Dequeue(){

            if (_stackOne.Count == 0)
                return default(T);

            while (_stackOne.Count > 0)
            { 
                _stackTwo.Push(_stackOne.Pop());
            }

            T value = _stackTwo.Pop();
           
            while(_stackTwo.Count > 0)
            {
                _stackOne.Push(_stackTwo.Pop());
            }

            return value;
        }
    }
}
