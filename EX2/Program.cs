using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Declarations
            int secret;
            int guess;
            bool playAgain = true;
            string answerPlayAgain;

            Random rnd = new Random();

            // Process to play the game repeatedly
            while (playAgain)
            {
                secret = rnd.Next(1, 101); // Random number between 1 and 100
                bool winning = false;      // Reset the winning flag for each new game

                Console.WriteLine("Guess the secret number between 1 and 100!");

                // Game loop until the user wins
                while (!winning)
                {
                    Console.Write("Enter your guess: ");
                    if (int.TryParse(Console.ReadLine(), out guess))
                    {
                        if (guess > secret)
                        {
                            Console.WriteLine("Your guess is too high.");
                        }
                        else if (guess < secret)
                        {
                            Console.WriteLine("Your guess is too low.");
                        }
                        else
                        {
                            Console.WriteLine("Congratulations! You guessed the number!");
                            winning = true; // Player won
                        }
                    }
                    else
                    {
                        Console.WriteLine("Invalid input. Please enter a number.");
                    }
                }

                // Asking if the player wants to play again
                Console.Write("Do you want to play again? (Y/N): ");
                answerPlayAgain = Console.ReadLine();

                if (answerPlayAgain.ToUpper() != "Y")
                {
                    playAgain = false; // Exit the main loop
                }
            }

            Console.WriteLine("Thanks for playing! Goodbye!");
        }
    }
}