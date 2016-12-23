using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
using WcfServiceMessage;
using System.ServiceModel.Channels;

namespace ConsoleApplication3
{
    class Program
    {
        static void Main(string[] args)
        {
            var factory = new ChannelFactory<IFlyService>(new BasicHttpBinding(), "http://192.168.1.123:8733/MyService/");
            var channel = factory.CreateChannel();
            //构造msg
            //http://tempuri.org/IFlyService/Inovke 指向的路由地址

            var msg = Message.CreateMessage(MessageVersion.Soap11, "http://tempuri.org/IFlyService/Inovke", "我给服务器发送信息");
            msg.Headers.Add(MessageHeader.CreateHeader("dt", string.Empty, DateTime.Now.ToString("yyyy-MM-dd")));
            var res = channel.Inovke(msg);

            var result = res.GetBody<string>();
            //获取body
            Console.WriteLine(result);
            Console.ReadKey();
        }
    }
}
