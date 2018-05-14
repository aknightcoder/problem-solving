using System;
namespace problemsolving.StacksAndQueues
{
    public class NStacks<T>
    {
        private readonly T[] _stackArray;

        private readonly int[] _stackPointers;

        private const int StackSize = 10;

        public NStacks(int stackCount)
        {
            _stackArray = new T[StackSize * stackCount];

            _stackPointers = new int[stackCount];

            Initialize();
        }

        public T Pop(int stackNum) 
        {
            if (IsEmpty(stackNum))
                throw new Exception("Stack is empty.");

            var stackIndex = GetLastIndex(stackNum);

            var value = _stackArray[stackIndex];

            _stackArray[stackIndex] = default(T);

            _stackPointers[stackNum]--;

            return value;
        }

        public void Push(int stackNum, T value)
        {
            if (IsFull(stackNum))
                throw new Exception("Stack is full.");

            var nextIndex = GetNextIndex(stackNum);

            _stackArray[nextIndex] = value;
        }

        private int GetLastIndex(int stackNum){

            return GetStartIndex(stackNum) + _stackPointers[stackNum];
        }

        private int GetNextIndex(int stackNum) 
        {
            _stackPointers[stackNum] = _stackPointers[stackNum] + 1;

            return GetStartIndex(stackNum) + _stackPointers[stackNum];
        }

        private int GetStartIndex(int stackNum)
        {
            return stackNum * StackSize;
        }

        private void Initialize(){
            
            for (var i = 0; i < _stackPointers.Length; i++){
                _stackPointers[i] = -1;
            }
        }

        private bool IsEmpty(int stackNum) {
            
            return _stackPointers[stackNum] == StackSize - 1;
        }

        private bool IsFull(int stackNum) {
            
            return _stackPointers[stackNum] == StackSize - 1;
        }

    }
}
