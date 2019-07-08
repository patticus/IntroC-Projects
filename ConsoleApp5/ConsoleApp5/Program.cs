using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            if (num1 > 5)
                Console.WriteLine("Greater than five");
            else
                Console.WriteLine("less than five");

            const int HIGHNUM = 30;
            const int LOWNUM = 15;
            int number = int.Parse(Console.ReadLine());
            if (number > HIGHNUM)
                Console.WriteLine("Your number is higher than the high number");
            else if (number > LOWNUM)
                Console.WriteLine("Your number is lower than the low number");
            else if (number < HIGHNUM && number > LOWNUM)
                Console.WriteLine("Your number is between the high number and the low number");

            else if (number == HIGHNUM)
                Console.WriteLine("Your number is equal to the high number");
            else if (number == LOWNUM)
                Console.WriteLine("Your number is equal to the low number");


            float gpa = float.Parse(Console.ReadLine());
            float examScore = float.Parse(Console.ReadLine());
            if ((gpa >= 3.0 && examScore >= 60) || (gpa <= 3.0 && examScore >= 80))
                Console.WriteLine("You've been accepted into college");
            else
                Console.WriteLine("Sorry.");

            float grade = float.Parse(Console.ReadLine());

            if (grade >= 90 && grade <= 100)
                Console.WriteLine("A");
            else if (grade >= 80 && grade <= 89)
                Console.WriteLine("B");
            else if (grade >= 70 && grade <= 79)
                Console.WriteLine("C");
            else if (grade >= 60 && grade <= 69)
                Console.WriteLine("D");
            else if (grade <= 59)
                Console.WriteLine("Failing");



        }
    }
}
