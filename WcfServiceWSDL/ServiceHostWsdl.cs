using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Description;
using System.Text;
using System.Threading.Tasks;

namespace WcfServiceWSDL
{
    class ServiceHostWsdl
    {
        static void Main(string[] args)
        {
            ServiceHost host = new ServiceHost(typeof(FlyService), new Uri("http://localhost:8744/MyService/"));

            //这是我们服务的地址
            host.AddServiceEndpoint(typeof(IFlyService), new BasicHttpBinding(), string.Empty);

            host.Description.Behaviors.Add(new ServiceMetadataBehavior() { HttpGetEnabled = true });

            //mex元数据的地址
            host.AddServiceEndpoint(typeof(IMetadataExchange), MetadataExchangeBindings.CreateMexHttpBinding(), "mex");

            host.Open();

            Console.WriteLine("WCF 服务开启");

            Console.Read();
        }
    }
}
