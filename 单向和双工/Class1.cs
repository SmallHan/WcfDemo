using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace 单向和双工
{
    class Class1
    {
        static void Main(string[] args)
        {
            using (ServiceHost sh = new ServiceHost(typeof(Fly)))
            {
                sh.Open();
                Console.WriteLine("wcf服务开启了");
                Console.ReadKey();

            }
        }
    }
}
