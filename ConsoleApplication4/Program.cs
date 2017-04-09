using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
using System.ServiceModel.Channels;
using WcfServiceCannel;

namespace ConsoleApplication4
{
    class Program
    {
        #region 查看 信道栈 
        //static void Main(string[] args)
        //{
        //    var msg = Message.CreateMessage(MessageVersion.Soap11, "http://tempuri.org/IFlyService/Invoke", "发送消息给服务端");
        //    var basic = new BasicHttpBinding();
        //    //创建绑定元素

        //    //[0]: {System.ServiceModel.Channels.TextMessageEncodingBindingElement}   文本编码
        //    //[1]: {System.ServiceModel.Channels.HttpTransportBindingElement}  http传输
        //    var t1 = basic.CreateBindingElements();

        //    // [0]: {System.ServiceModel.Channels.TransactionFlowBindingElement}  支持事务。
        //    //[1]: {System.ServiceModel.Channels.BinaryMessageEncodingBindingElement} 二进制的编码。
        //    //[2]: {System.ServiceModel.Channels.WindowsStreamSecurityBindingElement} 安全
        //    //[3]: {System.ServiceModel.Channels.TcpTransportBindingElement} tcp传输
        //    var basic1 = new NetTcpBinding();
        //    var t2 = basic1.CreateBindingElements();
        //    var factory = new ChannelFactory<IFlyService>(new BasicHttpBinding(), "http://192.168.1.123:8733/MyService/");
        //    var channel = factory.CreateChannel();
        //    var msg1 = channel.Invoke(msg);
        //    Console.WriteLine(msg1.GetBody<string>());
        //    Console.ReadKey();

        //}
        #endregion

        static void Main(string[] args)
        {
            var msg = Message.CreateMessage(MessageVersion.Soap11, "http://tempuri.org/IFlyService/Invoke", "发送消息给服务端");
            var basic = new BasicHttpBinding();
            //创建绑定元素

            //[0]: {System.ServiceModel.Channels.TextMessageEncodingBindingElement}   文本编码
            //[1]: {System.ServiceModel.Channels.HttpTransportBindingElement}  http传输
            var t1 = basic.CreateBindingElements();

            // [0]: {System.ServiceModel.Channels.TransactionFlowBindingElement}  支持事务。
            //[1]: {System.ServiceModel.Channels.BinaryMessageEncodingBindingElement} 二进制的编码。
            //[2]: {System.ServiceModel.Channels.WindowsStreamSecurityBindingElement} 安全
            //[3]: {System.ServiceModel.Channels.TcpTransportBindingElement} tcp传输
            var basic1 = new NetTcpBinding();
            var t2 = basic1.CreateBindingElements();
            var factory = new ChannelFactory<IFlyService>(new BasicHttpBinding(), "http://192.168.1.123:8733/MyService/");
            /*
             *  [0]: {System.ServiceModel.Channels.TransactionFlowBindingElement}  支持事物
                [1]: {System.ServiceModel.Channels.BinaryMessageEncodingBindingElement}  二进制的编码
                [2]: {System.ServiceModel.Channels.WindowsStreamSecurityBindingElement}  安全
                [3]: {System.ServiceModel.Channels.TcpTransportBindingElement}   tcp传输
             * 
             * 看到这四个elements，我们就知道tcp支持哪些功能，可以任意组合elements
             */


            var channel = factory.CreateChannel();
            var msg1 = channel.Invoke(msg);
            Console.WriteLine(msg1.GetBody<string>());
            Console.ReadKey();
        }
    }
}
