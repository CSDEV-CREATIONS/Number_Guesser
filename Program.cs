using System;
using System.Collections.Generic;
using System.Linq;

namespace Number_Guesser
{
    class Program
    {
        static void Main(string[] args)
        {
            // Generate A Random Number For The Guess
            Random r = new Random();
            // Initialization Of The Correct Answer
            int correctAnswer = r.Next(0, 100);
            // Initialization Of The Win Variable
            bool win = false;
            // Initialization Of The Thank You Message
            String thankYouMsg = "Thank you for playing";

            // Loop To Keep Guessing The Answer
            do
            {
                Console.Write("Guess a number between 0 and 100: ");
                String g = Console.ReadLine();
                int i = int.Parse(g);

                if (i > correctAnswer)
                {
                    Console.WriteLine("Your guess is too high. Please try again");

                }
                else if (i < correctAnswer)
                {
                    Console.WriteLine("Your guess is too low. Please try agian");
                }
                else if (i == correctAnswer)
                {
                    Console.WriteLine("Good job!. Your answer is correct");
                    win = true;
                }

                Console.WriteLine();
                // Continuous Loop While Win Is False
            } while (win == false);
            {

                Console.WriteLine(thankYouMsg);

            }


        }


    }
}
