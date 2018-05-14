using System;

namespace problemsolving
{
    public class ThreeStacks<T>
    {
        private T[] _stackArray;

        private int[] _stackPointers;

        private const int _stackSize = 30;

        public ThreeStacks(){

            _stackArray = new T[_stackSize];

            _stackPointers = new int[3];
        }

        public void Put(T value, int stackNum){

            int currentPosition = GetCurrentPosition(stackNum);

            _stackArray[currentPosition] = value;

            _stackPointers[stackNum] = currentPosition;
                    
        }

        public T Pop(int stackNum){

            int currentPosition = GetCurrentPosition(stackNum);

            if (currentPosition < _stackSize / 3 * stackNum - 1)
                return default(T);
            
            T value =  _stackArray[currentPosition];

            _stackPointers[stackNum]--;

            return value;
        }

        private int GetCurrentPosition(int stackNum)
        {
            int currentPosition;

            if (_stackPointers[stackNum] == 0)
                currentPosition =  _stackArray.Length / 3 * stackNum - 1;

            currentPosition = _stackPointers[stackNum]++;

            if (currentPosition > (_stackArray.Length / 3) * stackNum)
                throw new Exception("Stack is full");

            return currentPosition;
        }
    }
}
