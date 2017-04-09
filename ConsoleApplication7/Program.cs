using ConsoleApplication7.ServiceReference1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication7
{
    class Program
    {
        static void Main(string[] args)
        {
            FlyServiceClient flyClient = new FlyServiceClient();
            flyClient.Inovke(string.Empty);
            Console.WriteLine("ok");
            Console.ReadKey();
        }
    }
}
