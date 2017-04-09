using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;

namespace WcfServiceCannel
{
    public class ServiceHostChannel
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
