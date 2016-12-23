using ConsoleApplication1.ServiceReference1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            ChannelFactory<IFlyService> factory = new ChannelFactory<IFlyService>(new BasicHttpBinding(), "http://localhost:8744/MyService/");

            var channel = factory.CreateChannel();

            var res=channel.Fly(new Student() { 
                ID=3,
                Name="小瀚"
            });
            Console.WriteLine(res.Code+"-"+res.Message);
            Console.WriteLine("调用成功");

            factory.Close();

            Console.Read();
        }
    }
}
