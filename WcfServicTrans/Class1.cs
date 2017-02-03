using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace WcfServicTrans
{
    public class Class1
    {
        static void Main(string[] args)
        {
            ServiceHost host = new ServiceHost(typeof(FlyService));

            host.Open();

            Console.WriteLine("WCF 服务开启");

            Console.Read();           
        }
    }
}
