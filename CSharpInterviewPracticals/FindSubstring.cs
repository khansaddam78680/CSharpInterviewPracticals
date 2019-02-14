using System.Collections.Generic;

namespace Practice
{
    /// <summary>
    /// Program to find substring of a given string.
    /// </summary>
    public static class FindSubstring
    {
        /// <summary>
        /// Function to get substring.
        /// </summary>
        /// <param name="str"></param>
        /// <return>Substrings</return>
        public static List<string> Substring(string str)
        {
            List<string> substring = new List<string>();

            for (int i = 1; i < str.Length; i++)
            {
                for (int j = 0; j <= str.Length-i; j++)
                {
                    substring.Add(str.Substring(j, i));
                }
            }

            return substring; 
        }
    }
}
