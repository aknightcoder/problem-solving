namespace problemsolving.Arrays
{
    public class UniqueChars
    {
        public bool HasUniqueChars(string str)
        {
            bool[] bool_array = new bool[128]; //ascii 

            if (str.Length >= 128) return false;

            for (int i = 0; i < str.Length; i++)
            {
                int intValue = str[i];

                if (bool_array[intValue])
                    return false; // we already found it.
                
                bool_array[intValue] = true;
            }

            return true;
        }
    }
}
