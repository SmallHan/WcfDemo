using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WCFClient
{
    class Program
    {
        static void Main(string[] args)
        {
            ServiceFly.FlyClient fly = new ServiceFly.FlyClient();
            fly.FlyReads("Hello World");
            Console.WriteLine("进MSMQ队列");
            Console.ReadKey();
        }
    }
}
