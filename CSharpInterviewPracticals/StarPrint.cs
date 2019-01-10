using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TestConsole
{
    public class StarPrint
    {
        public void Print()
        {
            int i, j;

            for (i = 4; i >= 0; i--)
            {
                for (j = 0; j <= i; j++)
                {
                    /* There Are two ways to do it.
                    1st way is good enough if you know how many lines you have to print.*/
                    //if (i == 4 || i == 2 || i == 0)
                    //{
                    //    Console.Write("*");
                    //}

                    /* 2nd Always use this way if you have to print in odd and even format.
                     0 to print odd and 1 to print even */
                    if (i % 2 == 0)
                    {
                        Console.Write("*");
                    }
                }
                Console.WriteLine("");
            }
        }
    }
}
