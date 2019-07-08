using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EuroYenConversion
{
    class Program
    {
        static void Main(string[] args)
        {
            const float EURO_CONV_RATE = 0.88f;
            const float YEN_CONV_RATE = 112.53f;
            float dollars;
            float euros;
            float yen;

            Console.Write("Please enter the dollar amount: $");
            dollars = float.Parse(Console.ReadLine());
            euros = dollars * EURO_CONV_RATE;
            yen = dollars * YEN_CONV_RATE;
            Console.WriteLine("${0} = €{1:C}", dollars, euros);
            Console.WriteLine("${0} = ¥{1:C}", dollars, yen);
            Console.WriteLine("{0} = {1} Euros", dollars.ToString ("C"), euros.ToString("C"));
            Console.WriteLine("{0} = {1} Yen", dollars.ToString("C"), yen.ToString("C"));
            Console.ReadKey();





        }
    }
}
