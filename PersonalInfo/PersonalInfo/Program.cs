using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalInfo
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Write, compile, and test a program named PersonalInfo that displays 
              a person’s name, birthdate, work phone number, and cell phone number. */

            string name;
            int birthMonth;
            int birthDay;
            int birthYear;
            long workPhone;
            long cellPhone; //using long variables because a 10-digit number is too big for int


            Console.Write("Please enter your name: ");
            name = Console.ReadLine();
            Console.Write("Please enter your birth month as MM: "); //the user enters month as a number (e.g. 05 for May)
            birthMonth = int.Parse(Console.ReadLine());
            Console.Write("Please enter your birth day of the month as DD: ");
            birthDay = int.Parse(Console.ReadLine());
            Console.Write("Please enter your birth year as YYYY: ");
            birthYear = int.Parse(Console.ReadLine());
            Console.Write("Please enter your work phone number as a 10-digit number: ");
            workPhone = long.Parse(Console.ReadLine());
            Console.Write("Please enter your cell phone number as a 10-digit number: ");
            cellPhone = long.Parse(Console.ReadLine());
            Console.WriteLine();

            //each variable is stored in memory from the user input by the Console.ReadLine() method
            //the program will now display the personal information back to the user using the Console.Writeline() method

            
            Console.WriteLine("Name: {0}", name);
            //the program takes the user entered month number and converts it to the corresponding month name
            if (birthMonth == 01)
                Console.WriteLine("Birthdate: January {0}, {1}", birthDay, birthYear);
            if (birthMonth == 02)
                Console.WriteLine("Birthdate: February {0}, {1}", birthDay, birthYear);
            if (birthMonth == 03)
                Console.WriteLine("Birthdate: March {0}, {1}", birthDay, birthYear);
            if (birthMonth == 04)
                Console.WriteLine("Birthdate: April {0}, {1}", birthDay, birthYear);
            if (birthMonth == 05)
                Console.WriteLine("Birthdate: May {0}, {1}", birthDay, birthYear);
            if (birthMonth == 06)
                Console.WriteLine("Birthdate: June {0}, {1}", birthDay, birthYear);
            if (birthMonth == 07)
                Console.WriteLine("Birthdate: July {0}, {1}", birthDay, birthYear);
            if (birthMonth == 08)
                Console.WriteLine("Birthdate: August {0}, {1}", birthDay, birthYear);
            if (birthMonth == 09)
                Console.WriteLine("Birthdate: September {0}, {1}", birthDay, birthYear);
            if (birthMonth == 10)
                Console.WriteLine("Birthdate: October {0}, {1}", birthDay, birthYear);
            if (birthMonth == 11)
                Console.WriteLine("Birthdate: November {0}, {1}", birthDay, birthYear);
            if (birthMonth == 12)
                Console.WriteLine("Birthdate: December {0}, {1}", birthDay, birthYear);
            
            Console.WriteLine("Work Phone Number: {0:(###) ###-####}", workPhone);
            //the program re-formats the 10-digit number entered by the user into regular phone number format e.g. (555) 555-5555
            Console.WriteLine("Cell Phone Number: {0:(###) ###-####}", cellPhone);
            Console.ReadKey();

        }
    }
}
