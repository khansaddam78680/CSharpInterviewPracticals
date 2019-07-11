using System;

namespace TestConsole
{
    /// <summary>
    /// Program to calculate loan emi.
    /// </summary>
    public static class EmiCalc
    {
        /// <summary>
        /// Calculates the Emi per month based on inputs.
        /// </summary>
        /// <param name="Amount"></param>
        /// <param name="Rate"></param>
        /// <param name="TerminYear"></param>
        public static void Calculate(float Amount, float Rate, float TerminYear)
        {
            float EmiPerMonth;
            float IntrestAmount;
            float TotalPayableAmount;

            Rate = Rate / (12 * 100);
            TerminYear = TerminYear * 12;
            EmiPerMonth = Amount * Rate * (float)Math.Pow(1 + Rate, TerminYear) /
                        (float)(Math.Pow(1 + Rate, TerminYear) - 1);

            TotalPayableAmount = EmiPerMonth * TerminYear;
            IntrestAmount = TotalPayableAmount - Amount;
            Console.WriteLine("Your EMI per Month is : "+ Math.Round(EmiPerMonth));
            Console.WriteLine("Total Loan Amount Including Intrest : " + Math.Round(TotalPayableAmount));
            Console.WriteLine("The Intrest Amount against Loan Taken : " + Math.Round(IntrestAmount));
            Console.WriteLine(Environment.NewLine);
            Console.WriteLine("No\t Emi Paid\t Amount Paid\t Intrest Paid\t Remaining Balance");
            int no = 0;
            for (int i = Convert.ToInt16(TerminYear); i >= 1; i--)
            {
                no++;
                float IntrestPerMonth = Rate * Amount;
                float AmountPerMonth = EmiPerMonth - IntrestPerMonth;
                Amount = Amount - AmountPerMonth;
                Console.WriteLine(string.Format("{0}\t {1}\t\t {2}\t\t {3}\t\t {4}", no, Math.Round(EmiPerMonth), 
                                        Math.Round(AmountPerMonth), Math.Round(IntrestPerMonth), Math.Round(Amount)));
            }
        }
    }
}
