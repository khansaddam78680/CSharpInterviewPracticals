using System;

namespace TestConsole
{
    public static class RemoveDuplicateString
    {
        public static string RemoveString(string strToRemove)
        {
            // Keeps all encountered letters to this string.
            string orgString = String.Empty;

            // Keeps the result in this string.
            string resultString = String.Empty;

            foreach (char value in strToRemove)
            {
                // See if character is in the table.
                if (orgString.IndexOf(value) == -1)
                {
                    // Append to the table and the result.
                    orgString += value;
                    resultString += value;
                }
            }
            return resultString;
        }
    }
}
