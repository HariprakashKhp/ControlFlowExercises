using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class Factorial
    {
        int num;
        public int findFactorial()
        {
            Console.WriteLine("Please enter a number to find factorial");
            try
            {
                num = Convert.ToInt32(Console.ReadLine());
            }
            catch (Exception)
            {
                Console.WriteLine("Please enter a valid number");
            }

            var total = 1;

            for(var i=1; i<=num; i++)
            {
                total *= i;
            }

            return total;
        }
    }
}
