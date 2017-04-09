using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
using System.ServiceModel.Channels;

namespace ConsoleApplication5
{
    class Program
    {
        static void Main(string[] args)
        {
            //WSHttpBinding 在 BasicHttpBinding上增加了 事务和安全
            var basic = new WSHttpBinding();
            var t1 = basic.CreateBindingElements();

            /*
             [0]: {System.ServiceModel.Channels.TransactionFlowBindingElement} //支持事务
             [1]: {System.ServiceModel.Channels.SymmetricSecurityBindingElement://支持安全
             [2]: {System.ServiceModel.Channels.TextMessageEncodingBindingElement}//文本编码
             [3]: {System.ServiceModel.Channels.HttpTransportBindingElement}//http传输
             */

            var t2 = new WSDualHttpBinding().CreateBindingElements();
            //var channel = new FlyServiceClient();
            //var factory = new ChannelFactory<WsWcfService.IFlyService>(new WSHttpBinding(), "http://127.0.0.1:8733/FlyService/");
            //var channel = factory.CreateChannel();

            var msg = Message.CreateMessage(MessageVersion.Soap11, "http://tempuri.org/IFlyService/Inovke", "我给服务器发送了消息了");
            msg.Headers.Add(MessageHeader.CreateHeader("dt", string.Empty, DateTime.Now.ToString("yyyy-MM-dd")));
            //var res = channel.Inovke(msg);

            //var result = res.GetBody<string>();
            //获取body
            //Console.WriteLine(result);
            Console.ReadKey();

            //var t2 = new BasicHttpBinding().CreateBindingElements();

            /*
                  [0]: {System.ServiceModel.Channels.TextMessageEncodingBindingElement}
                  [1]: {System.ServiceModel.Channels.HttpTransportBindingElement}
             */
            Console.ReadKey();
        }
    }
}
