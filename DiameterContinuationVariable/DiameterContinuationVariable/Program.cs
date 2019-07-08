using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiameterContinuationVariable
{
    class Program
    {
        static void Main(string[] args)
        {
            float radius;
            float diameter;
            //const float PI = 3.14f;


            Console.Write("Please enter the radius of the circle in inches to determine its diameter: ");
            radius = float.Parse(Console.ReadLine());
            diameter = radius * 2;
            Console.WriteLine("The diameter of the circle is {0} inches.", diameter);
            Console.WriteLine();
            Console.WriteLine("Enter a new value? Y / N");

            while ((Console.ReadLine().ToUpper() == "Y"))
            {
                Console.Write("Please enter the radius of the circle in inches to determine its diameter: ");
                radius = float.Parse(Console.ReadLine());
                diameter = radius * 2;
                Console.WriteLine("The diameter of the circle is {0} inches.", diameter);
                Console.WriteLine();
                Console.WriteLine("Enter a new value? Y / N");
            }

            Console.WriteLine("End of program");
            Console.ReadKey();
        }
    }
}
