using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingFinal
{
    class Program
    {
        // Patrick Johnson - Final Project

        /*2.	Create an application that processes bank transactions.
                •	The program should loop until the user chooses to quit.
                •	The user enters the account number and account owner name and the starting balance. 
                •	The program asks the user to enter a count of how many transactions for this account.
                •	For every transaction, the program asks for the type (deposit or withdrawal) and the amount. The program adjusts the account balance accordingly.
                •	If there are insufficient funds for a withdrawal, the program prints an error and the transaction is not completed.
                •	After processing the transactions for this account, the program outputs the new balance.*/

        static void Main(string[] args)
        {
            string firstName;
            string lastName;
            double accountNumber;//using double for account number as it could be longer than maximum int value
            int transDecision;//using ints for decisions, types, and amounts as they will always be whole numbers.
            int transAmount;
            int transType;
            double withdrawal;//doubles for cash values
            double deposit;
            double balance = 0; //set initial balance at 0 dollars

            Console.WriteLine("Welcome to South Hills banking! \n");
            Console.Write("Please enter your first name: ");
            firstName = Console.ReadLine();
            Console.Write("Please enter your last name: ");      //user enters their full name and account number
            lastName = Console.ReadLine();
            Console.Write("Please enter your account number: ");
            accountNumber = double.Parse(Console.ReadLine());
            Console.Clear();
            Console.WriteLine();
            Console.WriteLine("     {0, -18} {1} {2}", "ACCOUNT NAME:", firstName, lastName);
            Console.WriteLine("     {0, -18} {1}", "ACCOUNT NUMBER:", accountNumber);  //displays user account info and balance - aligned for better readability 
            Console.WriteLine("     {0, -18} {1:C}", "BALANCE:", balance);
            Console.WriteLine();

            Console.WriteLine("Would you like to make a transaction? \n"); 
            Console.WriteLine("     1 - Start New Transaction");
            Console.WriteLine("     0 - Quit");
            transDecision = int.Parse(Console.ReadLine()); //priming input for the loop - 1 starts the loop and 0 quits
            Console.WriteLine();

            while (transDecision != 0) //actually any number other than 0 will start the loop, including 1, but 0 always quits. Prompted for 1 for ease of understanding
            {
                Console.Write("How many transactions would you like to make? "); // prompting for transaction amount 
                transAmount = int.Parse(Console.ReadLine());
                Console.Clear();

                for (int i = 1; i <= transAmount; i++) //for loop takes the transaction amount
                {
                    Console.WriteLine("Transaction {0}", i); //displays the transaction number
                    Console.WriteLine("~~~~~~~~~~~~~");
                    Console.WriteLine("What type of transaction? \n"); //prompts the user for deposit or withdrawal
                    Console.WriteLine("     1 - Deposit");
                    Console.WriteLine("     2 - Withdrawal");
                    transType = int.Parse(Console.ReadLine()); // user enters 1 for deposit or 2 for withdrawal

                    if (transType == 1) //decision statement for deposit
                    {
                        Console.Write("Please enter the deposit amount: $");
                        deposit = double.Parse(Console.ReadLine()); //user enters deposit
                        balance += deposit; //adds deposit to balance
                        Console.WriteLine();
                        Console.WriteLine("Deposit of {0:C} successful!", deposit);
                        Console.WriteLine("Current account balance: {0:C}", balance); //shows account balance after successful deposit
                    }

                    if (transType == 2) //decision statement for withdrawal
                    {
                        Console.Write("Please enter the withdrawal amount: $");
                        withdrawal = double.Parse(Console.ReadLine()); //user enters withdrawal
                        
                        while (balance < withdrawal) //remains on the same transaction if the user enters a withdrawal number higher than current balance
                        {
                            Console.WriteLine();
                            Console.WriteLine("You have insufficient funds for this withdrawal.");
                            Console.WriteLine("Current account balance: {0:C} \n", balance);
                            Console.Write("Please enter a new withdrawal amount: $");
                            withdrawal = double.Parse(Console.ReadLine());

                        }
                        
                        balance -= withdrawal; //subtracts withdrawal from balance
                        Console.WriteLine();
                        Console.WriteLine("Withdrawal of {0:C} successful!", withdrawal);
                        Console.WriteLine("Current account balance: {0:C}", balance);
                        
                    }

                    Console.WriteLine();
                    Console.WriteLine("Press enter to continue. . .\n"); //continues to next transaction - didn't have this originally but allows the user to look over previous transaction before continuing to the next one
                    Console.ReadKey();
                    Console.Clear();

                }
                Console.WriteLine("Transactions completed! \n"); //after the for loop has ended, displays the user's account information again
                Console.WriteLine("     {0, -18} {1} {2}", "ACCOUNT NAME:", firstName, lastName);
                Console.WriteLine("     {0, -18} {1}", "ACCOUNT NUMBER:", accountNumber);
                Console.WriteLine("     {0, -18} {1:C}", "BALANCE:", balance);
                Console.WriteLine();
                Console.WriteLine("Would you like to make another transaction? \n");
                Console.WriteLine("     1 - Start New Transaction");
                Console.WriteLine("     0 - Quit");
                transDecision = int.Parse(Console.ReadLine()); //redoing the priming input at the end of the loop
            }

            Console.WriteLine();
            Console.WriteLine("Thank you for using South Hills banking!"); //will display when user enters 0 to quit
            Console.ReadKey();
        }
    }
}
