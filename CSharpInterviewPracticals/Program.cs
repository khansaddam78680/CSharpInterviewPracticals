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
            //Binary Search Tree
            Console.WriteLine("---------------***********------------");
            Console.WriteLine("1. Program for Binary search Tree");
            BinarySearchTree.Node n1 = new BinarySearchTree.Node(1, null, null);
            BinarySearchTree.Node n3 = new BinarySearchTree.Node(3, null, null);
            BinarySearchTree.Node n2 = new BinarySearchTree.Node(2, n1, n3);
            Console.WriteLine(BinarySearchTree.Contains(n2, 3));

            //User interface contains two types of user input controls: TextInput, which accepts all characters and NumericInput, which accepts only digits.
            Console.WriteLine("---------------***********------------");
            Console.WriteLine("2. Program to Find User interface");
            UserInput.TextInput input = new UserInput.NumericInput();
            input.Add('1');
            input.Add('a');
            input.Add('0');
            Console.WriteLine(input.GetValue());

            //Palindrome
            Console.WriteLine("---------------***********------------");
            Console.WriteLine("3. Program to Find Palindrome of any string");
            Console.Write("Enter The String to Validate as Palindrome:");
            string str = Console.ReadLine();
            if (Palindrome_with_ignorecase.IsPalindrome(str))
            {
                Console.WriteLine("Provided String is Palindrome");
            }
            else
            {
                Console.WriteLine("Provided String is not a Palindrome");
            }

            // Q.4 Print Star
            Console.WriteLine("---------------***********------------");
            Console.WriteLine("4. Program to print star in Odd numbers");
            StarPrint.Print();

            // Q.5 Program to Swap Numbers Without Creating Temporary Variable
            Console.WriteLine("---------------***********------------");
            Console.WriteLine("5. Program to Swap Numbers Without Creating Temporary Variable");
            Console.Write("Enter the First No: ");
            int firstNo=Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the Second No: ");
            int secondNo = Convert.ToInt32(Console.ReadLine());
            SwapNumWithoutTempVariable.SwapNumber(firstNo, secondNo);

            Console.ReadKey();
        }
    }
}
