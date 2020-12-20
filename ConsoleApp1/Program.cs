using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("start");
            createData d = new createData();
            d.create();
            collectUUID cu = new collectUUID();
            var mydata = cu.getUUIDs(d.span);
            foreach (var dd in mydata)
            {
                Console.WriteLine(dd);
            }
            Console.WriteLine("finish");
            var k = Console.ReadKey();
        }
    }
}