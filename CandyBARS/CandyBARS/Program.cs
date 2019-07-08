using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CandyBARS
{
    /*A) Write a program that computes the amount of money the band club will receive from the proceeds
    of their candy bar sales.They sell the candy bars for $1.50 per bar. Purchases for the bars 
    are in cases, with each case having 100 bars.Each case costs $100.00. They are required
    to give the student government organization 10% of their earnings.Display their { the bands}
    proceeds, showing the amount given to the student government association.Show all the values formatted 
    with currency.And, allow user input an  number of bars they sold and to then show how much money
    would they make if they sold XX cases?*/

    class Program
    {
        static void Main(string[] args)
        {
            const float caseCost = 100.00f; //using float datatype for currency
            const float barCost = 1.50f;
            int barsSold; //using integer datatype for whole numbers
            int caseAmount;

            Console.Write("Please enter the number of cases you bought: ");
            caseAmount = int.Parse(Console.ReadLine()); //allows the user to enter the number of cases they purchased
            Console.WriteLine();
            Console.WriteLine("You bought {0} cases of candy bars at $100 each for a total of {1:C}.", caseAmount, caseAmount * caseCost); //displays to the user how many they bought and how much they spent
            Console.WriteLine("You have {0} candy bars to sell from the cases you bought. \n", caseAmount * 100); //displays how many candy bars they have to sell from the cases
            Console.Write("Please enter the number of candy bars you sold: ");//asks the user to enter the number of candy bars they sold
            barsSold = int.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("You sold {0} candy bars at $1.50 each for a total of {1:C}. You have {2} bars left over.", barsSold, barsSold * barCost, (caseAmount * 100) - barsSold); //outputs to the user the number of bars they sold, how much revenue, and how many bars left over
            Console.WriteLine();
            Console.WriteLine("You must give {0:C} to the student government for their 10% cut. \n", (barsSold * barCost) * 0.1); //subtracts 10% of earnings from revenue
            Console.WriteLine("Your revenue after the cut is {0:C}", (barsSold * barCost) * 0.9); // displays revenue after the 10% is subtracted
            if((((barsSold * barCost) * 0.9) - (caseAmount * caseCost)) > 0) //if statement for if there was a positive or negative net profit
                Console.WriteLine("Your net profit is: {0:C}.", ((barsSold * barCost) * 0.9) - (caseAmount * caseCost)); //shows total profit
            else
                Console.WriteLine("You have -{0:C} in losses. Sell more candy bars!", ((barsSold * barCost) * 0.9) - (caseAmount * caseCost)); //displays if negative profit
            Console.ReadKey();

        }
    }
}
