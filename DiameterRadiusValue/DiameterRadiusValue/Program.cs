using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiameterRadiusValue
{
    class Program
    {
        static void Main(string[] args)
        {
            float radius;
            float diameter;

            Console.Write("Please enter the radius of the circle in inches to determine its diameter, or enter 0 to quit program: ");
            radius = float.Parse(Console.ReadLine());

            while (radius != 0)
            {
                diameter = radius * 2;
                Console.WriteLine("The diameter of the circle is {0} inches.", diameter);
                Console.WriteLine();
                Console.Write("Please enter a new radius value in inches to determine its diameter, or enter 0 to quit program: ");
                radius = float.Parse(Console.ReadLine());
            }

            Console.WriteLine("End of program");
            Console.ReadKey();


        }
    }
}
