//Question 1 

using System;
namespace ConsoleApp1
{
    public class Valid
    {
        string stringRead;
        public void ReadStream()
        {
            Console.WriteLine("Please enter a number from 1 to 10");
            stringRead =  Console.ReadLine();
        }

        public void writeStream()
        {
            int number = Convert.ToInt32(stringRead);
            Console.WriteLine(number < 10 && number > 0 ? "Valid": "Invalid");
        }
    }
}
