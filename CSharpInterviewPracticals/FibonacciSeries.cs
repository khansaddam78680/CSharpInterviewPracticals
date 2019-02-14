using System;

namespace Practice
{
    /// <summary>
    /// Program to Display the fibonacci series upto user input.
    /// </summary>
    public static class FibonacciSeries
    {
        /// <summary>
        /// This method is used to display fibonacci series upto user input.
        /// </summary>
        /// <param name="no"></param>
        public static void PrintSeries(int no)
        {
            int result = 0;

            for (int i = 0; i < no; i++)
            {
                if (i == 0)
                {
                    Console.Write("Fibonacci Seires is: {0} ", i);
                }
                else if (i == 1)
                {
                    Console.Write("{0} ", i);
                }
                else if (i > 1)
                {
                    int firstNo = 0, secondNo = 1;
                    for (int j = 2; j <= i; j++)
                    {
                        result = firstNo + secondNo;
                        firstNo = secondNo;
                        secondNo = result;
                    }
                    Console.Write("{0} ", result);
                }

            }
        }
    }
}
