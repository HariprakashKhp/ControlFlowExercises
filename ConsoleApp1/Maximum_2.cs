using System;

namespace ConsoleApp1
{
    public class Maximum_2
    {
        string list;
        public void readString()
        {
            Console.WriteLine("Please enter the list of numbers with comma separation");
            list = Console.ReadLine();
            string[] listArray = list.Split(',');
            int[] listNumber = new int[listArray.Length];
            for (int i = 0; i < listArray.Length; i++)
            {
                listNumber[i] = Convert.ToInt32(listArray[i].Trim());
            }
            var biggerNum = 0;
            foreach (var num in listNumber)
            {
                
                biggerNum = num > biggerNum ? num : biggerNum;
            }
            Console.WriteLine(biggerNum);
        }
    }
}
