using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IfElseExamples
{
    class Program
    {
        static void Main(string[] args)
        {
            string comparison;
            Console.Write("Enter a number:"); ;
            double var1 = double.Parse(Console.ReadLine());
            Console.Write("Enter another number:");
            double var2 = double.Parse(Console.ReadLine());
            if (var1 < var2)
                comparison = "less than";
            else
            {
                if (var1 == var2)
                    comparison = "equal to";
                else
                    comparison = "greater than";
            }
            Console.WriteLine("The first number is {0} the second number", comparison);
            Console.ReadKey();

        }
    }
}
