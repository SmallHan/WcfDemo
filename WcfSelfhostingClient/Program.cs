using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WcfSelfhostingClient
{
    class Program
    {
        static void Main(string[] args)
        {
            WcfSelfhosting.Service1Client sc = new WcfSelfhosting.Service1Client();
            Console.WriteLine(sc.GetData(200));
            Console.ReadKey();
        }
    }
}
