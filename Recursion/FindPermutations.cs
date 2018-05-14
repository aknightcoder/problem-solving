using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace problemsolving.Recursion
{
    public class FindPermutations
    {
        public IEnumerable<string> Find(string strValue, int startIndex = 0){

            if (string.IsNullOrEmpty(strValue))
                return Enumerable.Empty<string>();

            var hashset = new HashSet<string>();

            for (var i = startIndex; i < strValue.Length; i++)
            {
                
                strValue = SwapValue(strValue, startIndex, i);

                var subResults = Find(strValue, startIndex + 1);

                if (subResults != null)
                {
                    foreach(var subResult in subResults)
                    {
                        if (!hashset.Contains(subResult))
                            hashset.Add(subResult);
                    }
                }

                hashset.Add(strValue);

                strValue = SwapValue(strValue, startIndex, i);
            }

            return hashset;
        }

        static string SwapValue(string strValue, int startIndex, int endIndex)
        {
             var sb = new StringBuilder(strValue);

            var tmp = sb[startIndex];

            sb[startIndex] = sb[endIndex];

            sb[endIndex] = tmp;

            return sb.ToString();
        }
    }
}
