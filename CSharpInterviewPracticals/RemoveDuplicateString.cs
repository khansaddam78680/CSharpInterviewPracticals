using System;

namespace TestConsole
{
    /// <summary>
    /// Program to Remove Duplicate Strings.
    /// </summary>
    public static class RemoveDuplicateString
    {
        /// <summary>
        /// This function removes the duplicates from the given string. 
        /// </summary>
        /// <param name="strToRemove"></param>
        /// <returns>New string without duplication</returns>
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
