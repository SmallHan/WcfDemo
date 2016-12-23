using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CmdClient
{
    class Program
    {
        static void Main(string[] args)
        {
            Service1Client s = new Service1Client();
            OrderClient o = new OrderClient();
            Console.WriteLine(s.GetData(100));
            Console.WriteLine(o.DoWork());
            Console.ReadKey();
        }
    }
}
