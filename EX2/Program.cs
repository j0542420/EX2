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
            //declaration
            int secret = 0;
            int guess = 0;

            bool winning = false; // flag to reflect the winning condition

            bool playAgain = true;
            string answerPlayAgain = true;

            //computer generate a random secret number

            Random rnd = new Random();
            secret = rnd.Next(secret);

            //proccess to play again
            while (playAgain = true)
            {

                //program will ask user to input a number to guess secret number, until win
                while (winning == false)
                {
                    Console.WriteLine("What is your guess number");
                    guess = Convert.ToInt32(Console.ReadLine());


                    //if the guessing number is greater than, print the number is too large
                    if (guess > secret)
                    {
                        Console.WriteLine("Number is too large");
                    }
                    //if the guessing number is less than, print out the number is to small
                    else if (guess < secret)
                    {
                        Console.WriteLine("Number is too small");
                    }
                    // if the guessing number is secret, you win and exit
                    else
                    {
                        Console.WriteLine("you have Won!");
                        winning = true;
                    }
                    Console.WriteLine("Play again? (Y/N)");

                    answerPlayAgain = Console.ReadLine();


                }
            }
            
            Console.WriteLine("BYE!");
            Console.ReadLine();
        }
    }
}
