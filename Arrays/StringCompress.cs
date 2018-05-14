using System.Text;

namespace problemsolving.Arrays
{
    public class StringCompress
    {
        public string Compress(string str){
            if (string.IsNullOrEmpty(str))
                return str;

            var sb = new StringBuilder();

            var currentChar = str[0];
            var currentCharCount = 1;

            for (int i = 1; i < str.Length; i++)
            {
                if (str[i] == currentChar)
                {
                    currentCharCount++;
                    continue;
                }

                AppendChars(sb, currentChar, currentCharCount);
                currentChar = str[i];
                currentCharCount = 1; 
            }

            AppendChars(sb, currentChar, currentCharCount);

            return sb.ToString();
        }

        private void AppendChars(StringBuilder sb, char currentChar, int currentCharCount)
        {
            if (currentCharCount == 1)
                sb.Append(currentChar);
            else
                sb.Append(string.Format("{0}{1}", currentChar, currentCharCount));
        }
    }
}
