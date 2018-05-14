namespace problemsolving.LinkedList
{
    public class SumOfValues
    {
        public int Carry { get; set; }

        public Node Value { get; set; }

        private Node _currentValue;

        public void AddValue(int sum){

            var newNode = new Node(sum, null);

            if (Value == null){
                Value = newNode;
                _currentValue = Value;
            }    
            else{
                _currentValue.Next = newNode;
                _currentValue = _currentValue.Next;
            }
        }
    }
}
