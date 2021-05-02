using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //var validClass = new Valid();
            //validClass.ReadStream();
            //validClass.writeStream();

            //var max = new Maximum();
            //max.readStream();
            //max.writeStream();

            //var port = new PortraitFinder();
            //port.readStream();
            //port.writeStream();

            //var speed = new SpeedLimit();
            //speed.calculateDemerit();

            var three = new DivByThree();
            three.DivThree();
        }
    }
}
