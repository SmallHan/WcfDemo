using ConsoleApplication2.ServiceReference1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            ChannelFactory<IFlyService> factory = new ChannelFactory<IFlyService>(new BasicHttpBinding(), "http://192.168.1.123:8744/MyService/");

            var channel = factory.CreateChannel();

            //var res = channel.Fly("Hello World");
            //Console.WriteLine(res);
            var res = channel.MyFly();
            Console.WriteLine(res);
            Console.WriteLine("调用成功");

            factory.Close();

            Console.Read();
        }
    }
}
