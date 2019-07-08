using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SavingsInterest
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter your account number:");
            double accNum = double.Parse(Console.ReadLine());
            Console.Write("Please enter your First name: ");
            string firstName = Console.ReadLine();
            Console.Write("Please enter your Last name: ");
            string lastName = Console.ReadLine();
            Console.Write("Please enter the ammount you wish to deposit: $");
            double deposit = double.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("NAME ON ACCOUNT: {0} {1}", firstName, lastName);
            Console.WriteLine("ACCOUNT NUMBER: {0}", accNum);
            Console.WriteLine("CURRENT BALANCE: {0:C}", deposit);
            Console.WriteLine();
            Console.WriteLine("Your current interest rate is 4%. The following is a projection of the growth of your balance over a 20 year period.");
            Console.WriteLine();

            for (int i = 1; i < 21; i++)
            {
                deposit *= 1.04;
                Console.WriteLine("YEAR {0}: {1:C}", i, deposit);
                
            }

            Console.ReadKey();
        }
    }
}
