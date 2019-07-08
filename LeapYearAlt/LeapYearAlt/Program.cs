using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeapYearAlt
{
    public class Program
    {
        static void Main(string[] args)
        {
            double year;

            Console.WriteLine("This program will tell you whether or not the year you enter is a leap year.");
            Console.Write("Enter the year or 0 to quit: ");
            year = double.Parse(Console.ReadLine());
            Console.WriteLine();

            while (year > 0)
            {
                if ((year % 400) == 0)
                    Console.WriteLine("The year {0} is a leap year. \r\n", year);
                else if ((year % 100) == 0)
                    Console.WriteLine("The year {0} is not a leap year. \r\n", year);
                else if ((year % 4) == 0)
                    Console.WriteLine("The year {0} is a leap year. \r\n", year);
                else
                    Console.WriteLine("The year {0} is not a leap year.\r\n", year);
                Console.Write("Enter the year or 0 to quit: ");
                year = int.Parse(Console.ReadLine());
                Console.WriteLine();
            }
            Console.WriteLine("Have a great year!");
            Console.ReadKey();
        }
    }
}
