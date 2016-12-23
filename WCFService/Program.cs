using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace WCFService
{
    class Program
    {
        static void Main(string[] args)
        {
            using (ServiceHost sh = new ServiceHost(typeof(Fly)))
            {
                sh.Open();
                Console.WriteLine("wcf服务services已经启动。。。");
                Console.ReadKey();
            }
        }
    }
}
