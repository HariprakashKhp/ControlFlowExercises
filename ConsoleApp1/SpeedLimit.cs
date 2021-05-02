using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class SpeedLimit
    {
        int cameraSpeed;
        int vehicleSpeed;
        int demeritPoint;

        public void calculateDemerit()
        {
            Console.WriteLine("Please enter camera speed in numbers (kmph)");
            try
            {
                cameraSpeed = int.Parse(Console.ReadLine());
            }
            catch (Exception)
            {
                Console.WriteLine("Plesae try again! Only number is allowed");
            }
            Console.WriteLine("Please enter vehicle speed in numbers (kmph)");
            try
            {
                vehicleSpeed = int.Parse(Console.ReadLine());
            }
            catch (Exception)
            {
                Console.WriteLine("Plesae try again! Only number is allowed");
            }

            if(vehicleSpeed < cameraSpeed)
            {
                Console.WriteLine("Ok");
            }else if(vehicleSpeed > cameraSpeed)
            {
                var diff = vehicleSpeed - cameraSpeed;
                demeritPoint = diff / 5;
                if(demeritPoint < 12)
                    Console.WriteLine("This is your demerit points" + demeritPoint);
                else
                    Console.WriteLine("Licence Suspended");
            }
        }
    }
}
