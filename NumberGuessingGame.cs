﻿using System;

namespace NumberGuessingGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();

            int winNum = r.Next(0, 100);

            bool win = false;

            do
            {
                Console.WriteLine("Guess a number inbetween 0 and 100");
                string s = Console.ReadLine();

                int i = int.Parse(s);

                if (i > winNum)
                {
                    Console.WriteLine("Too High! Guess Lower...");
                }
                else if(i < winNum)
                {
                    Console.WriteLine("Too Low! Guess Higher...");
                }
                else if (i == winNum)
                {
                    Console.WriteLine("YOU WIN!");
                    win = true;
                }

            } while (win == false);

            Console.WriteLine("Thank you for playing the game!");
           
         
        }
    }
}
