using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class Maximum
    {
        int num1;
        int num2;
        public void readStream()
        {
            Console.WriteLine("Please enter num 1");
            try
            {
                num1 = Convert.ToInt32(Console.ReadLine());
            }
            catch (Exception)
            {
                Console.WriteLine("please enter a valid number 1");
            }
            Console.WriteLine("Please enter num 2");
            try
            {
                num2 = Convert.ToInt32(Console.ReadLine());
            }
            catch (Exception)
            {
                Console.WriteLine("please enter a valid number 2");
            }
        }

        public void writeStream()
        {
            Console.WriteLine(num1 > num2 ? "The bigger number is " + num1 : "The bigger number is " + num2);
        }
    }
}
