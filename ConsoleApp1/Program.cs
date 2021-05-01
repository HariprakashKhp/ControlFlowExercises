using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            var validClass = new Valid();
            validClass.ReadStream();
            validClass.writeStream();
        }
    }
}
