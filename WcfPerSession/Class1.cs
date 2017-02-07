using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace WcfPerSession
{
    public class Class1
    {
        static void Main(string[] args)
        {
            using (ServiceHost sh = new ServiceHost(typeof(SocketService)))
            {
                sh.Open();
                Console.WriteLine("wcf服务开启了");
                Console.ReadKey();
            }
        }
    }
}
