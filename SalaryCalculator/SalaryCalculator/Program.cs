using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalaryCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            double baseSalary;
            int totalSales;
            double commissionRate;
            double paySales;
            double totalPay;

            Console.Write("Please enter your base salary: $");
            baseSalary = double.Parse(Console.ReadLine());
            Console.Write("Please enter your total number of sales: ");
            totalSales = int.Parse(Console.ReadLine());
            Console.Write("Please enter your base salary: $");
            commissionRate = double.Parse(Console.ReadLine());

            paySales = commissionRate * totalSales;
            totalPay = baseSalary + paySales;

            string conversion;
            conversion = totalPay.ToString("C");
            Console.WriteLine("Your total pay is: {0}", conversion);
            Console.WriteLine(totalPay.ToString("Your total pay is: c"));
            Console.ReadKey();



            


        }
    }
}
