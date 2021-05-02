using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class DivByThree
    {
        public void DivThree()
        {
            var count = 0;
            for(var i =1; i<=100; i++)
            {
                if(i%3 == 0)
                {
                    count++;
                }
            }
            Console.WriteLine(count);
        }
    }
}
