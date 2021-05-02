using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class Sum
    {
        public void addInputs()
        {
            Console.WriteLine("Please start entering the numbers to add");
            var total = 0;
            while(true)
            {
                string input = "";
                try
                {
                    input = Console.ReadLine();
                }
                catch (Exception)
                {
                    Console.WriteLine("please enter a number or 'ok' to termiate");
                }
                if(input.ToLower() == "ok")
                {
                    break;
                }else if (input == "")
                {
                    continue;
                }
                var num = int.Parse(input);
                total += num;
            }
            Console.WriteLine(total);
        }
    }
}
