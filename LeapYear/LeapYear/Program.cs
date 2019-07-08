using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeapYear
{
    class Program
    {
        static void Main(string[] args)
        {
            int year;
            bool isLeapYear = false;

            Console.Write("Enter the year, or 0 to quit: ");
            year = int.Parse(Console.ReadLine());
            Console.WriteLine();



            while (year > 0)
            {
                if ((year % 4) == 0)
                {
                    if ((year % 100) == 0)
                    {
                        if ((year % 400) == 0)
                        {
                            isLeapYear = true;
                        }
                        else isLeapYear = false;
                    }
                    else isLeapYear = true;
                        
                }

                if (isLeapYear == true)
                {
                    Console.WriteLine("The year {0} is a leap year", year);
                }
                else Console.WriteLine("The year {0} is not a leap year", year);

                while (year > 0) 
                {
                    Console.WriteLine("                           @@@@@@           @@@@@@");
                    Console.WriteLine("                         @@@@@@@@@@       @@@@@@@@@@");
                    Console.WriteLine("                       @@@@@@@@@@@@@@   @@@@@@@@@@@@@@");
                    Console.WriteLine("                     @@@@@@@@@@@@@@@@@ @@@@@@@@@@@@@@@@@");
                    Console.WriteLine("                    @@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@");
                    Console.WriteLine("                   @@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@");
                    Console.WriteLine("                   @@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@");
                    Console.WriteLine("                   @@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@");
                    Console.WriteLine("                    @@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@");
                    Console.WriteLine("                     @@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@");
                    Console.WriteLine("                      @@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@");
                    Console.WriteLine("                       @@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@");
                    Console.WriteLine("                         @@@@@@@@@@@@@@@@@@@@@@@@@@@");
                    Console.WriteLine("                           @@@@@@@@@@@@@@@@@@@@@@@");
                    Console.WriteLine("                             @@@@@@@@@@@@@@@@@@@");
                    Console.WriteLine("                               @@@@@@@@@@@@@@@");
                    Console.WriteLine("                                 @@@@@@@@@@@");
                    Console.WriteLine("                                   @@@@@@@");
                    Console.WriteLine("                                     @@@");
                    Console.WriteLine("                                      @");
                }
                      
                Console.WriteLine();
                Console.Write("Enter the year, or 0 to quit: ");
                year = int.Parse(Console.ReadLine());
                Console.WriteLine();
            }

            Console.WriteLine("Have a nice year!");
            Console.ReadKey();
        
        }
    }
}
