namespace problemsolving.LinkedList
{
    public class SumOfLists
    {
        private bool _storeForward;

        public SumOfLists(bool storeForward){
            _storeForward = storeForward;
        }

        public SumOfValues Sum(Node left, Node right)
        {
            if (left == null && right == null) return null;

            if (left == null) return new SumOfValues() { Value = right };

            if (right == null) return new SumOfValues() { Value = left };

            int leftLength = Utils.GetLength(left);

            int rightLength = Utils.GetLength(right);

            if (leftLength != rightLength)
            {
                if (leftLength < rightLength)
                {
                    left = Utils.AddPadding(left, rightLength - leftLength);
                }
                else
                {
                    right = Utils.AddPadding(right, leftLength - rightLength);
                }
            }

            return _storeForward ? AddForwardNumbers(left, right) : AddReverseNumbers(left, right);
        }

        private SumOfValues AddForwardNumbers(Node left, Node right)
        {
           var sumOfValues = new SumOfValues();

            while(left != null){
                
                var sum = left.Value + right.Value + sumOfValues.Carry;

                UpdateSumValue(sumOfValues, sum);

                left = left.Next;
                right = right.Next;
            }

            return sumOfValues;
        }

        private SumOfValues AddReverseNumbers(Node left, Node right)
        {
            if (left == null && right == null)
                return new SumOfValues();

            var sumOfValues = AddReverseNumbers(left.Next, right.Next);

            var sum = left.Value + right.Value + sumOfValues.Carry;

            UpdateSumValue(sumOfValues, sum);

            return sumOfValues;
        }

        private void UpdateSumValue(SumOfValues sumOfValues, int sum){

            if (sum > 10)
            {
                sumOfValues.Carry = 1;

                sumOfValues.AddValue(sum % 10);
            }
            else {

                sumOfValues.AddValue(sum);

                sumOfValues.Carry = 0;
            }
        }
    }
}
