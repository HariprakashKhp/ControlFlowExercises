using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class PortraitFinder
    {
        int width;
        int height;

        public void readStream()
        {
            Console.WriteLine("Please enter width of the image");
            try
            {
                width = int.Parse(Console.ReadLine());
            }
            catch (Exception)
            {
                Console.WriteLine("Plesae try again! Only number is allowed");
            }
            Console.WriteLine("Please enter height of the image");
            try
            {
                height = int.Parse(Console.ReadLine());
            }
            catch (Exception)
            {
                Console.WriteLine("Plesae try again! Only number is allowed");
            }
        }

        public void writeStream()
        {
            if(width > height)
            {
                Console.WriteLine("This is a landscape image");
            }else
            {
                Console.WriteLine("This is a portrait image");
            }
        }
    }
}
