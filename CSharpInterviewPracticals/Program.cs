using System;

namespace TestConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            int InputByUser = 0;
            do
            {
                InputByUser = Menudisplay();
                if (InputByUser == 1)
                {
                    Question1(InputByUser);
                }
                else if (InputByUser == 2)
                {
                    Question2(InputByUser);
                }
                else if (InputByUser == 3)
                {
                    Question3(InputByUser);
                }
                else if (InputByUser == 4)
                {
                    Question4(InputByUser);
                }
                else if (InputByUser == 5)
                {
                    Question5(InputByUser);
                }
                else if (InputByUser == 6)
                {
                    Question6(InputByUser);
                }
                else if (InputByUser == 7)
                {
                    Question7(InputByUser);
                }
                else if (InputByUser == 8)
                {
                    Question8(InputByUser);
                }
                else if (InputByUser == 9)
                {
                    Question9(InputByUser);
                }
                else if (InputByUser == 10)
                {
                    Question10(InputByUser);
                }
                else if (InputByUser == 11)
                {
                    Question11(InputByUser);
                }
                else if (InputByUser > 12)
                {
                    InvalidQuestionNo();
                }
            } while (InputByUser != 12);
            Console.WriteLine("Please Wait !!!Exiting the Program...");
            System.Threading.Thread.Sleep(3000);
        }

        /// <summary>
        /// This Function displays the Question Menu.
        /// </summary>
        /// <returns>Question No by User</returns>
        static int Menudisplay()
        {
            Console.Clear();
            while (true)
            {
                Console.WriteLine("***************************************************************************" + Environment.NewLine +
                          "***************************************************************************" + Environment.NewLine +
                          "***     **   ***   ** ******  **     ***   ***  **      **   ******     ***" + Environment.NewLine +
                          "***      **  ***  **  ****    **    **    ** ** ** *  * **   ****       ***" + Environment.NewLine +
                          "***       **     **   ******  *****  ***   ***  **  **  **   ******     ***" + Environment.NewLine +
                          "***************************************************************************" + Environment.NewLine +
                          "***************************************************************************" + Environment.NewLine);

                Console.WriteLine("!!!Please Select the Program Number From Below to the See Output!!!" + Environment.NewLine);
                Console.WriteLine("1. Program for binary search tree contains a given value.");
                Console.WriteLine("2. Program ignore each non-numeric character.");
                Console.WriteLine("3. Program to check if a given word is a palindrome. Character case should be ignored.");
                Console.WriteLine("4. Program to print Odd number Star Print.");
                Console.WriteLine("5. Program to swap input numbers with each other with out creating any variable.");
                Console.WriteLine("6. Program to to display the input string after removing duplicate strings.");
                Console.WriteLine("7. Program to check provided number is Armstrong or not.");
                Console.WriteLine("8. Program to find the Factorial of the given number.");
                Console.WriteLine("9. Program to Find all possible Substring from the user Input");
                Console.WriteLine("10. Program to print Fibonacci Series upto nth term from the user Input");
                Console.WriteLine("11. Program to calculate EMI per month from the user Input");
                Console.WriteLine("12. Exit the Program" + Environment.NewLine);

                Console.Write("Enter The Question No: ");
                int QuestionNo = 0;
                if (Int32.TryParse(Console.ReadLine(), out QuestionNo))
                {
                    return QuestionNo;
                }
                else
                {
                    Console.WriteLine("Please Enter Numbers Only");
                }
            }
        }

        /// <summary>
        /// This Function Executes Program No.1
        /// </summary>
        /// <param name="no"></param>
        static void Question1(int no)
        {
            Console.WriteLine("You Have Entered to Program No .{0}" + Environment.NewLine, no);
            BinarySearchTree.Node n1 = new BinarySearchTree.Node(1, null, null);
            BinarySearchTree.Node n3 = new BinarySearchTree.Node(3, null, null);
            BinarySearchTree.Node n2 = new BinarySearchTree.Node(2, n1, n3);
            Console.WriteLine(BinarySearchTree.Contains(n2, 3));
            Console.ReadLine();
        }

        /// <summary>
        /// This Function Executes Program No.2
        /// </summary>
        /// <param name="no"></param>
        static void Question2(int no)
        {
            Console.WriteLine("You Have Entered to Program No .{0}" + Environment.NewLine, no);
            UserInput.TextInput input = new UserInput.NumericInput();
            input.Add('1');
            input.Add('a');
            input.Add('0');
            Console.WriteLine(input.GetValue());
            Console.ReadLine();
        }

        /// <summary>
        /// This Function Executes Program No.3
        /// </summary>
        /// <param name="no"></param>
        static void Question3(int no)
        {
            Console.WriteLine("You Have Entered to Program No .{0}" + Environment.NewLine, no);
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
            Console.ReadLine();
        }

        /// <summary>
        /// This Function Executes Program No.4
        /// </summary>
        /// <param name="no"></param>
        static void Question4(int no)
        {
            Console.WriteLine("You Have Entered to Program No .{0}" + Environment.NewLine, no);
            StarPrint.OddStarPrint();
            Console.ReadLine();
        }

        /// <summary>
        /// This Function Executes Program No.5
        /// </summary>
        /// <param name="no"></param>
        static void Question5(int no)
        {
            Console.WriteLine("You Have Entered to Program No .{0}" + Environment.NewLine, no);
            Console.Write("Enter the First No: ");
            int firstNo = 0;// Convert.ToInt32(Console.ReadLine());
            if (Int32.TryParse(Console.ReadLine(), out firstNo))
            {
                Console.Write("Enter the Second No: ");
                int secondNo = 0;// Convert.ToInt32(Console.ReadLine());
                if (Int32.TryParse(Console.ReadLine(), out secondNo))
                {
                    SwapNumWithoutTempVariable.SwapNumber(firstNo, secondNo);
                }
                else
                {
                    Console.WriteLine("Please Enter Numbers Only");
                }
            }
            else
            {
                Console.WriteLine("Please Enter Numbers Only");
            }
            Console.ReadLine();
        }

        /// <summary>
        /// This Function Executes Program No.6
        /// </summary>
        /// <param name="no"></param>
        static void Question6(int no)
        {
            Console.WriteLine("You Have Entered to Program No .{0}" + Environment.NewLine, no);
            Console.Write("Enter the String to Remove Duplicate: ");
            string str5 = Console.ReadLine();
            Console.WriteLine("The Result String is : {0}", RemoveDuplicateString.RemoveString(str5));
            Console.ReadLine();
        }

        /// <summary>
        /// This Function Executes Program No.7
        /// </summary>
        /// <param name="no"></param>
        static void Question7(int no)
        {
            Console.WriteLine("You Have Entered to Program No .{0}" + Environment.NewLine, no);
            Console.Write("Enter the Number to Check: ");
            int armNo = 0;// Convert.ToInt32(Console.ReadLine());
            if (Int32.TryParse(Console.ReadLine(), out armNo))
            {
                if (NumIsArmstrongOrNot.IsArmstrong(armNo))
                {
                    Console.WriteLine("Provided Number is an Armstrong number");
                }
                else
                {
                    Console.WriteLine("Provided Number is not Armstrong number");
                }
            }
            else
            {
                Console.WriteLine("Please Enter Numbers Only");
            }
            Console.ReadLine();
        }

        /// <summary>
        /// This Function Executes Program No.8
        /// </summary>
        /// <param name="no"></param>
        static void Question8(int no)
        {
            Console.WriteLine("You Have Entered to Program No .{0}" + Environment.NewLine, no);
            Console.Write("Enter the Number to Find Factorial: ");
            int factorailNo = 0;// Convert.ToInt32(Console.ReadLine());
            if (Int32.TryParse(Console.ReadLine(), out factorailNo))
            {
                Console.WriteLine("The Factorial of {0} is {1}", factorailNo, FactorialNo.ForLoop_Fact(factorailNo)); // Using For Loop
                //Console.WriteLine("The Factorial of {0} is {1}", factorailNo, FactorialNo.WhileLoop_Fact(factorailNo)); // Using While Loop
                //Console.WriteLine("The Factorial of {0} is {1}", factorailNo, FactorialNo.Recursive_Fact(factorailNo)); // Using Recursion
            }
            else
            {
                Console.WriteLine("Please Enter Numbers Only");
            }
            Console.ReadLine();
        }

        /// <summary>
        /// This Function Executes Program No.9
        /// </summary>
        /// <param name="no"></param>
        static void Question9(int no)
        {
            Console.WriteLine("You Have Entered to Program No .{0}" + Environment.NewLine, no);
            Console.Write("Enter the string: ");
            string str = Console.ReadLine();
            var substr = FindSubstring.Substring(str);
            foreach (var item in substr)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();
        }

        /// <summary>
        /// This Function Executes Program No.10
        /// </summary>
        /// <param name="no"></param>
        static void Question10(int no)
        {
            Console.WriteLine("You Have Entered to Program No .{0}" + Environment.NewLine, no);
            Console.Write("Enter the length of the Fibonacci Series: ");
            int input = 0;// Convert.ToInt32(Console.ReadLine());
            if (Int32.TryParse(Console.ReadLine(), out input))
            {
                FibonacciSeries.PrintSeries(input);
            }
            else
            {
                Console.WriteLine("Please Enter Numbers Only");
            }
            Console.ReadLine();
        }

        /// <summary>
        /// This Function Executes Program No.11
        /// </summary>
        /// <param name="no"></param>
        static void Question11(int no)
        {
            bool ValidInput = false;
            Console.WriteLine("You Have Entered to Program No .{0}" + Environment.NewLine, no);
            float Principal = 0; float Intrest = 0; float Years = 0;
            while (!ValidInput)
            {
                Console.Write("Enter the principal amount of  Loan: ");

                if (float.TryParse(Console.ReadLine(), out Principal))
                {
                    if (Principal <= 999)
                    {
                        Console.WriteLine("Please Enter Amount  greater than or equal to 1000");
                        System.Threading.Thread.Sleep(1000);
                        //ClearCurrentConsoleLine();
                        Console.WriteLine(Environment.NewLine);
                    }
                    else
                    {
                        ValidInput = true;
                    }
                }
                else
                {
                    Console.WriteLine("Please Enter Numbers Only");
                    System.Threading.Thread.Sleep(1000);
                    //ClearCurrentConsoleLine();
                    Console.WriteLine(Environment.NewLine);
                }
            }
            ValidInput = false;

            while (!ValidInput)
            {
                Console.Write("Enter the rate of intrest per year: ");

                if (float.TryParse(Console.ReadLine(), out Intrest))
                {
                    if (Intrest <= 0)
                    {
                        Console.WriteLine("Intrest rate should be greater than 0.");
                        System.Threading.Thread.Sleep(1000);
                        //ClearCurrentConsoleLine();
                        Console.WriteLine(Environment.NewLine);
                    }
                    else
                    {
                        ValidInput = true;
                    }
                }
                else
                {
                    Console.WriteLine("Please Enter Numbers Only");
                    System.Threading.Thread.Sleep(1000);
                    //ClearCurrentConsoleLine();
                    Console.WriteLine(Environment.NewLine);
                }
            }

            ValidInput = false;

            while (!ValidInput)
            {
                Console.Write("Enter the Loan period (In Year): ");

                if (float.TryParse(Console.ReadLine(), out Years))
                {
                    if (Years <= 0)
                    {
                        Console.WriteLine("Term Year should be greater than 0.");
                        System.Threading.Thread.Sleep(1000);
                        //ClearCurrentConsoleLine();
                        Console.WriteLine(Environment.NewLine);
                    }
                    else
                    {
                        ValidInput = true;
                    }
                }
                else
                {
                    Console.WriteLine("Please Enter Numbers Only");
                    System.Threading.Thread.Sleep(1000);
                    //ClearCurrentConsoleLine();
                    Console.WriteLine(Environment.NewLine);
                }
            }

            EmiCalc.Calculate(Principal, Intrest, Years);
            Console.ReadLine();
        }

        /// <summary>
        /// Executes if user Enters invalid question number.
        /// </summary>
        static void InvalidQuestionNo()
        {
            Console.WriteLine("Please enter Valid Question no or Press 12 to Exit" + Environment.NewLine + Environment.NewLine + "Press Enter");
            Console.ReadLine();
        }

        //public static void ClearCurrentConsoleLine()
        //{
        //    int currentLineCursor = Console.CursorTop -2;
        //    Console.SetCursorPosition(0, Console.CursorTop -2);
        //    Console.Write(new string(' ', Console.BufferWidth - 0));
        //    Console.SetCursorPosition(0, currentLineCursor);
        //}

    }
}
