using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quarterback
{
    class Program
    {
        static void Main(string[] args)
        {
            double passYards = 0;
            double passAttempts = 0;
            double completions = 0;
            double avgYards = 0;
            double completionPercetage = 0;
            double totalYards = 0;
            double totalAttempts = 0;
            double totalCompletions = 0;

            for (int i = 1; i < 13; i++)
            {
                Console.Write("Please enter the number of passing yards for Game {0}: ", i);
                passYards = double.Parse(Console.ReadLine());
                Console.Write("Please enter the number of passing attempts for Game {0}: ", i);
                passAttempts = double.Parse(Console.ReadLine());
                Console.Write("Please enter the number of completions for Game {0}: ", i);
                completions = double.Parse(Console.ReadLine());
                totalYards += passYards;
                totalAttempts += passAttempts;
                totalCompletions += completions;
                avgYards = totalYards / i;
                completionPercetage = totalCompletions / totalAttempts;
            }

            Console.WriteLine("Average yards per game: {0:0.##}", avgYards);
            Console.WriteLine("Completion Percentage: {0:0.##}%", completionPercetage * 100);
            Console.ReadKey();
        }
    }
}
