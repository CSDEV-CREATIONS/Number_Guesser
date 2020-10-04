using System;
using System.Collections.Generic;
using System.Linq;

namespace Number_Guesser
{
    class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();
            int correctAnswer = r.Next(0, 100);
            bool win = false;
            String thankYouMsg = "Thank you for playing";

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
            } while (win == false);
            {

                Console.WriteLine(thankYouMsg);

            }


        }


    }
}
