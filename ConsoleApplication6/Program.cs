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
        static Random r1 = new Random();
        static void Main(string[] args)
        {
            //3个线程去执行
            Parallel.Invoke(Run, Run, Run);
            Console.Read();
        }
        static void Run()
        {
            FlyServiceClient client = new FlyServiceClient();
            //client.Inovke("test");
            string strNum = r1.Next(0, 1000).ToString();
            Console.WriteLine(strNum);
            client.Invoke1(strNum);
        }
    }
}
