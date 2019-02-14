using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestConsole
{
    /// <summary>
    /// This Program finds the Factorial of a Number using Different Ways.
    /// </summary>
    public static class FactorialNo
    {
        /// <summary>
        /// This program displays the Factorial of a Number using For Loop.
        /// </summary>
        /// <param name="factNo"></param>
        /// <returns>Factorial of a Number</returns>
        public static double ForLoop_Fact(int factNo)
        {
            double result = 1;
            for (int i = factNo; i >= 1; i--)
            {
                result = result * i;
            }
            return result;
        }

        /// <summary>
        /// This program displays the Factorial of a Number using While Loop.
        /// </summary>
        /// <param name="factNo"></param>
        /// <returns>Factorial of a Number</returns>
        public static double WhileLoop_Fact(int factNo)
        {
            double result = 1;
            while (factNo != 1)
            {
                result = result * factNo;
                factNo = factNo - 1;
            }
            return result;
        }

        /// <summary>
        /// This program displays the Factorial of a Number using Recursive Function.
        /// </summary>
        /// <param name="factNo"></param>
        /// <returns>Factorial of a Number</returns>
        public static double Recursive_Fact(int factNo)
        {
            if (factNo == 1)
            {
                return 1;
            }
            else
            {
                return factNo * Recursive_Fact(factNo - 1);
            }
        }
    }
}
