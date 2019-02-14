using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestConsole
{
    /// <summary>
    /// This Program Check Whether the Provided Number is an Armstrong or Not.
    /// </summary>
    public static class NumIsArmstrongOrNot
    {
        /// <summary>
        /// Function to Check Armstrong Number.
        /// </summary>
        /// <param name="no"></param>
        /// <returns>True/False</returns>
        public static bool IsArmstrong(int no)
        {
            int rem = 0, sum = 0;
            for (int i = no; i > 0; i = i / 10)
            {
                rem = i % 10;
                sum = sum + rem * rem * rem;
            }
            if (sum == no)
            {
                return true;
            }
            return false;
        }
    }
}
