using ConsoleApplication6.ServiceReference1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication6
{
    class Program
    {
        static void Main(string[] args)
        {
            //3个线程去执行
            Parallel.Invoke(Run, Run, Run);
            Console.Read();
        }
        static void Run()
        {
            FlyServiceClient client = new FlyServiceClient();
            client.Inovke("test");
        }
    }
}
