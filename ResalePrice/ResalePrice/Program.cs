using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResalePrice
{
    class Program
    {
        static void Main(string[] args)
        {
            int saleDay = 1;
            Console.Write("Please enter the price of the item, or enter 0 to quit: $");
            float price = float.Parse(Console.ReadLine());

            while (price != 0)
            {
                do
                {
                    Console.WriteLine("This item costs {0:C} on day {1}.", price, saleDay);
                    price = price * 0.9f;
                    ++saleDay;
                } while (saleDay < 8);

                Console.WriteLine();
                Console.Write("Please enter the price of the item, or enter 0 to quit: $");
                price = float.Parse(Console.ReadLine());
            }

            Console.WriteLine("Thanks for shopping!");
            Console.ReadKey();
        }
    }
}
