using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Looping
{
    class Program
    {
        static void Main(string[] args)
        {

            double num = 0;
            double sum = 0;

            while (num != 999)
            {
                sum += num;

                Console.Write("Please enter a number, or enter 999 to quit: ");
                num = double.Parse(Console.ReadLine()); 
                Console.WriteLine();
            }

            Console.WriteLine("The sum of the numbers is {0}.", sum);
            Console.ReadKey();
        }
    }
}
