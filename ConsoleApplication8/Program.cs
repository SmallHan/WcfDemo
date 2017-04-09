using ConsoleApplication8.ServiceReference1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication8
{
    class Program
    {
        static void Main(string[] args)
        {
            FlyServiceClient flyClient = new FlyServiceClient();
            Console.WriteLine(DateTime.Now);
            flyClient.DoBigAnalysisSlow("测试");
            Console.WriteLine(DateTime.Now);
            Console.ReadKey();
        }
    }
}
