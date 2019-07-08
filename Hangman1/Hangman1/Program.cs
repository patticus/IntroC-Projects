using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Speech.Synthesis;
using System.Threading;
using System.Threading.Tasks;

namespace Hangman1
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random((int)DateTime.Now.Ticks);

            string[] wordBank = { "Blue", "Black", "Yellow", "Orange", "Green", "Purple", "Elephant", "Lion", "Llama", "Frog", "Cow", "Infection", "Shithouse",  };

            string wordToGuess = wordBank[random.Next(0, wordBank.Length)];
            string wordToGuessUppercase = wordToGuess.ToUpper();

            StringBuilder displayToPlayer = new StringBuilder(wordToGuess.Length);
            for (int i = 0; i < wordToGuess.Length; i++)
                displayToPlayer.Append('_');

            List<char> correctGuesses = new List<char>();
            List<char> incorrectGuesses = new List<char>();

            int lives = 6;
            bool won = false;
            int lettersRevealed = 0;
            bool playAgain = false;

            string input;
            char guess;

            Console.WriteLine("Welcome to Hang Man!");
            Console.WriteLine("    __________        ");
            Console.WriteLine("   |          |       ");
            Console.WriteLine("   |                  ");
            Console.WriteLine("   |                  ");
            Console.WriteLine("   |                  ");
            Console.WriteLine("   |                  ");
            Console.WriteLine(" __|__                ");
            Console.WriteLine();

            while (!playAgain)
            {
                while (!won && lives > 0)
                {
                    Console.Write("Guess a letter: ");

                    input = Console.ReadLine().ToUpper();
                    guess = input[0];

                    if (correctGuesses.Contains(guess))
                    {
                        Console.WriteLine("You've already tried '{0}', and it was correct!", guess);
                        continue;
                    }
                    else if (incorrectGuesses.Contains(guess))
                    {
                        Console.WriteLine("You've already tried '{0}', and it was wrong!", guess);
                        continue;
                    }

                    if (wordToGuessUppercase.Contains(guess))
                    {
                        correctGuesses.Add(guess);

                        for (int i = 0; i < wordToGuess.Length; i++)
                        {
                            if (wordToGuessUppercase[i] == guess)
                            {
                                displayToPlayer[i] = wordToGuess[i];
                                lettersRevealed++;
                            }
                        }

                        if (lettersRevealed == wordToGuess.Length)
                            won = true;
                    }
                    else
                    {
                        incorrectGuesses.Add(guess);

                        Console.WriteLine("Nope, there's no '{0}' in it!", guess);
                        lives--;
                    }

                    if (lives == 5)
                    {
                        Console.WriteLine("    __________        ");
                        Console.WriteLine("   |          |       ");
                        Console.WriteLine("   |          O       ");
                        Console.WriteLine("   |                  ");
                        Console.WriteLine("   |                  ");
                        Console.WriteLine("   |                  ");
                        Console.WriteLine(" __|__                ");
                    }

                    if (lives == 4)
                    {
                        Console.WriteLine("    __________        ");
                        Console.WriteLine("   |          |       ");
                        Console.WriteLine("   |          O       ");
                        Console.WriteLine("   |          |       ");
                        Console.WriteLine("   |                  ");
                        Console.WriteLine("   |                  ");
                        Console.WriteLine(" __|__                ");
                    }

                    if (lives == 3)
                    {
                        Console.WriteLine("    __________        ");
                        Console.WriteLine("   |          |       ");
                        Console.WriteLine("   |        __O       ");
                        Console.WriteLine("   |          |       ");
                        Console.WriteLine("   |                  ");
                        Console.WriteLine("   |                  ");
                        Console.WriteLine(" __|__                ");
                    }

                    if (lives == 2)
                    {
                        Console.WriteLine("    __________        ");
                        Console.WriteLine("   |          |       ");
                        Console.WriteLine("   |        __O__     ");
                        Console.WriteLine("   |          |       ");
                        Console.WriteLine("   |                  ");
                        Console.WriteLine("   |                  ");
                        Console.WriteLine(" __|__                ");
                    }

                    if (lives == 1)
                    {
                        Console.WriteLine("    __________        ");
                        Console.WriteLine("   |          |       ");
                        Console.WriteLine("   |        __O__     ");
                        Console.WriteLine("   |          |       ");
                        Console.WriteLine("   |         /        ");
                        Console.WriteLine("   |                  ");
                        Console.WriteLine(" __|__                ");
                    }



                    Console.WriteLine(displayToPlayer.ToString());
                }

                if (won)
                {
                    Console.WriteLine("You won!");
                }

                else
                {
                    Console.WriteLine("    __________        ");
                    Console.WriteLine("   |          |       ");
                    Console.WriteLine("   |        __O__     ");
                    Console.WriteLine("   |          |       ");
                    Console.WriteLine("   |         / \\     ");
                    Console.WriteLine("   |                  ");
                    Console.WriteLine(" __|__                ");
                    Console.WriteLine("The word was '{0}'", wordToGuess);

                    SpeechSynthesizer synth = new SpeechSynthesizer();
                    synth.Speak("JJ thought he was good. He got wrecked. GG no rematch");
                    Console.WriteLine("0       0   00000    0      0     000000  0      0    00000   0   0         ");
                    Thread.Sleep(500);
                    Console.WriteLine(" 0     0   0     0   0      0    0        0      0   0     0  0  0       ");
                    Thread.Sleep(500);
                    Console.WriteLine("  0   0   0       0  0      0     0       0      0  0         0 0      ");
                    Thread.Sleep(500);
                    Console.WriteLine("   0 0    0       0  0      0      0000   0      0  0         00         ");
                    Thread.Sleep(500);
                    Console.WriteLine("    0     0       0  0      0          0  0      0  0         0 0         ");
                    Thread.Sleep(500);
                    Console.WriteLine("    0      0     0    0    0           0   0    0    0     0  0  0        ");
                    Thread.Sleep(500);
                    Console.WriteLine("    0       00000      0000       00000     0000      00000   0   0       ");
                    Thread.Sleep(2000);

                }


                Console.WriteLine("Would you like to play again ? (y / n)");

                if (Console.ReadLine().ToLower() != "y")
                    playAgain = true;
                lives = 6;
                won = false;
           


            }

            Console.WriteLine("Thanks for playing!");
            Console.ReadKey();

        }
    }
}
