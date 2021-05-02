using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class Guess
    {
        public void guessRandom()
        {
            var random = new Random();
            //The maxValue for the upper-bound in the Next() method is exclusive—the range includes minValue, maxValue - 1, and all numbers in between.
            int randomNumber = random.Next(1, 11);
            Console.WriteLine("Start guessing your input");
            for(var i=0; i<4; i++)
            {
                var guessNumber = Convert.ToInt32(Console.ReadLine());
                if (guessNumber == randomNumber)
                {
                    Console.WriteLine("you won");
                    break;
                } else if (i == 3)
                {
                    Console.WriteLine("you lose");
                }
            }

        }
    }
}
