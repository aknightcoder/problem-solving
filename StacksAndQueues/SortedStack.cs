namespace problemsolving.StacksAndQueues
{
    public class SortedStack
    {
        public CustomStack<int> Sort(CustomStack<int> sourceStack)
        {
            var sortedStack = new CustomStack<int>();

            while (!sourceStack.IsEmpty())
            {
                var currentValue = sourceStack.Pop();

                while (!sortedStack.IsEmpty() && sortedStack.Peek() > currentValue) 
                {
                    sourceStack.Push(sortedStack.Pop());
                }

                sortedStack.Push(currentValue);
            }

            return sortedStack;
        }
    }
}
