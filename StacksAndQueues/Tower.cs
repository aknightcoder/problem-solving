using System;
using System.Collections.Generic;

namespace problemsolving.StacksAndQueues
{
    public class Tower
    {
        public int Index { get; }

        public Stack<int> Disks { get; set; }

        public Tower(int index)
        {
            Index = index;

            Disks = new Stack<int>();
        }

        public void MoveDisk(Tower otherTower){

            if (IsEmpty() && otherTower.IsEmpty())
                return;

            if (IsDone() || otherTower.IsDone())
                return;

            if (IsEmpty())
                Push(otherTower.Pop());
            else if (!otherTower.IsEmpty() && Peek() > otherTower.Peek())
                Push(otherTower.Pop());
            else
                otherTower.Push(Pop());
        }

        public int Peek()
        {
            if (Disks == null)
                throw new Exception("Disks is null.");
            
            return Disks.Peek();
        }

        public int Pop()
        {
            if (Disks == null)
                throw new Exception("Disks is null.");
            
            return Disks.Pop();
        }

        public void Push(int value)
        {
            if (Disks == null)
                throw new Exception("Disks is null.");
            
            Disks.Push(value);
        }

        public bool IsDone()
        {
            return Index == 3 && Disks.Count == 4;
        }

        public bool IsEmpty()
        {
            if (Disks == null) return true;
            
            return Disks.Count == 0;
        }
    }
}
