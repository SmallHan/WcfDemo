using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Channels;
using System.Text;

namespace WsWcfService
{
    // 注意: 使用“重构”菜单上的“重命名”命令，可以同时更改代码和配置文件中的类名“Service1”。
    public class FlyService : IFlyService
    {
        public Message Inovke(Message msg)
        {
            var body = msg.GetBody<string>();   //获取body数据

            Console.WriteLine("   body={0}", body);

            //返回一个message
            var single = Message.CreateMessage(msg.Version, msg.Headers.Action + "Response", "我已经接受到信息了");

            return single;
        }
    }
}
