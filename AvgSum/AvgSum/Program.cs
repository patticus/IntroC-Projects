using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AvgSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = 0;
            double num = 0;
            double sum = 0;
            double avg = 0;

            Console.Write("Please enter the count of numbers: ");
            count = int.Parse(Console.ReadLine());

            for (int i = 0; i < count; i++)
            {
                Console.Write("Please enter the next number: ");
                num = double.Parse(Console.ReadLine());
                sum += num;
                avg = sum / count;
            }

            Console.WriteLine("The sum of the numbers is {0}.", sum);
            Console.WriteLine("The average of the numbers is {0}.", avg);
            Console.ReadKey();
        }
    }
}
