using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestConsole
{
    public static class SwapNumWithoutTempVariable
    {
        public static void SwapNumber(int firstNo,int secondNo)
        {
            firstNo = firstNo + secondNo;
            secondNo = firstNo - secondNo;
            firstNo = firstNo - secondNo;
            Console.WriteLine("Swapped Frist No is {0} and Second No is {1}", firstNo, secondNo);
        }
    }
}
