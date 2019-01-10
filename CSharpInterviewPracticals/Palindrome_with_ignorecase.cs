using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TestConsole
{
    public class Palindrome_with_ignorecase
    {
        public bool IsPalindrome(string word)
        {
            string palindrome = "";
            for (int i = word.Length - 1; i >= 0; i--) //String Reverse  
            {
                palindrome += word[i].ToString();
            }
            if (palindrome.ToLower() == word.ToLower()) // Checking whether string is palindrome or not  
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
