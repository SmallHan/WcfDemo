using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace 双工服务契约
{
    public class Client
    {
        static void Main(string[] args)
        {
            using (ServiceHost sh = new ServiceHost(typeof(ServerSocket)))
            {
                sh.Open();
                Console.WriteLine("wcf服务开启了");
                Console.ReadKey();

            }
        }
    }
}
