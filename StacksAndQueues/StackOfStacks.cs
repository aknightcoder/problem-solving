using System;
using System.Collections.Generic;

namespace problemsolving.StacksAndQueues
{
    public class StackOfStacks<T> where T : IComparable
    {
        private readonly int _stackThreshold;

        private Stack<Stack<T>> _stacks { get; }

        public StackOfStacks(int stackThreshold)
        {
            _stacks = new Stack<Stack<T>>();

            _stackThreshold = stackThreshold;

            Add();
        }

        public T Pop()
        {
            var currentStack = _stacks.Peek();

            var value = currentStack.Pop();

            if (_stacks.Count > 0 && currentStack.Count == 0)
            {
                Remove();
            }

            return value;
        }

        public void Push(T value)
        {
            var currentStack = _stacks.Peek();

            if (currentStack.Count >= _stackThreshold)
            {
                Add();

                currentStack = _stacks.Peek();
            }

            currentStack.Push(value);
        }

        private void Add()
        {
            if (_stacks == null) return;

            _stacks.Push(new Stack<T>());
        }

        private void Remove()
        {
            if (_stacks == null) return;

            _stacks.Pop();
        }
    }
}
