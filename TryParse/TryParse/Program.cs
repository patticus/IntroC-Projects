using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryParse
{
    class Program
    {
        static void Main(string[] args)
        {
            String[] values = { null, "160519", "9432.0", "16,667",
                          "   -322   ", "+4302", "(100);", "01FA", "12335", "-3392" };
            foreach (var value in values)
            {
                int number;

                bool success = Int32.TryParse(value, out number);
                if (success)
                {
                    Console.WriteLine("Converted '{0}' to {1}.", value, number);
                }
                else
                {
                    Console.WriteLine("Attempted conversion of '{0}' failed.",
                                       value ?? "<null>");
                }

                Console.ReadKey();
            }
        }
    }
}
