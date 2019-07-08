using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TipCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            float bill;
            float tip;

            Console.Write("Please enter the cost of your meal: $");
            bill = float.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("{0,25} {1,11} {2,5:C}  ||  {3,5:C} {4,5:C}", "Tip option examples:", "10% TIP: ", bill * .10f, "TOTAL: ", bill * 1.10f); //outputting the tips, formatted for alignment and currency
            Console.WriteLine("{0,37} {1,5:C}  ||  {2,5:C} {3,5:C}", "15% TIP: ", bill * .15f, "TOTAL: ", bill * 1.15f);
            Console.WriteLine("{0,37} {1,5:C}  ||  {2,5:C} {3,5:C}", "20% TIP: ", bill * .20f, "TOTAL: ", bill * 1.20f);
            Console.WriteLine();
            Console.Write("Please enter the % you would like to tip as a whole number (e.g. '20' for a 20% tip): "); //asks the user to input the tip they chose
            tip = float.Parse(Console.ReadLine());
            Console.WriteLine("You tipped at {0}% for {1:C}.", tip, (tip * 0.01) * bill); // outputs the percent they tipped and how much the tip was
            Console.WriteLine("Your total bill including the tip is {0:C}.", ((tip * 0.01) + 1) * bill); //calculates and outputs the total cost of the meal as bill + tip
            Console.ReadKey();
        }
    }
}
