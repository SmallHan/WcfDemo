using ClientTest.ServiceReference1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace ClientTest
{
    public class CallbackHandler : IServerSocketCallback
    {
        //服务实例的上下文信息。
        static InstanceContext site = new InstanceContext(new CallbackHandler());
        static ServerSocketClient proxy = new ServerSocketClient(site);

        public void PriceUpdate(string ticket, double price)
        {
            Console.WriteLine("{0}.{1}-{2}", DateTime.Now, ticket, price);
        }


        class Program
        {
            static void Main(string[] args)
            {
                proxy.RegiestForUpdates("MSPT");
                Console.WriteLine("OK");
                Console.ReadKey();
            }
        }
    }
}
