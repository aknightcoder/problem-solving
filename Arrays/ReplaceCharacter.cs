using System;
namespace problemsolving.Arrays
{
    public class ReplaceCharacter
    {
        public string Replace(char[] str, int length)
        {
            var spaceCount = 0;

            for (var i = 0; i < length; i++){
                if (str[i] == ' ')
                    spaceCount++;
            }

            var endIndex = length - 1 + spaceCount * 2;

            for (var i = length - 1; i >= 0; i--)
            {
                if (str[i] == ' ') {
                    str[endIndex] = '0';
                    str[endIndex - 1] = '2';
                    str[endIndex - 2] = '%';

                    endIndex = endIndex - 3;
                } 
                else
                {
                    str[endIndex] = str[i];
                    endIndex--;
                }
            }

            return new string(str);
        }
    }
}
