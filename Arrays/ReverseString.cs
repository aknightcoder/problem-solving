using System;
using System.Text;

namespace problemsolving.Arrays
{
    public class ReverseString
    {
        public string GetReverseString(string str)
        {
            if (string.IsNullOrEmpty(str)) return str;

            int midIndex = (str.Length - 1) / 2;
            int endIndex = str.Length - 1;

            var sb = new StringBuilder(str);

            for (int i = 0; i <= midIndex; i++){

                var tmp = sb[i];

                sb[i] = sb[endIndex - i];

                sb[endIndex - i] = tmp;
            }

            return sb.ToString();
        }
    }
}
