using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TestConsole
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //Palindrome
            Palindrome_with_ignorecase pdm = new Palindrome_with_ignorecase();
            Console.WriteLine(pdm.IsPalindrome("Deleveled"));

            //User interface contains two types of user input controls: TextInput, which accepts all characters and NumericInput, which accepts only digits.
            UserInput.TextInput input = new UserInput.NumericInput();
            input.Add('1');
            input.Add('a');
            input.Add('0');
            Console.WriteLine(input.GetValue());

            //Binary Search Tree
            BinarySearchTree.Node n1 = new BinarySearchTree.Node(1, null, null);
            BinarySearchTree.Node n3 = new BinarySearchTree.Node(3, null, null);
            BinarySearchTree.Node n2 = new BinarySearchTree.Node(2, n1, n3);
            Console.WriteLine(BinarySearchTree.Contains(n2, 3));

            // Q.4 Print Star
            StarPrint star = new StarPrint();
            star.Print();

            Console.ReadKey();
        }
    }
}
