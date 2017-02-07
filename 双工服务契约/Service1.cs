using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Threading;

namespace 双工服务契约
{
    // 注意: 使用“重构”菜单上的“重命名”命令，可以同时更改代码和配置文件中的类名“Service1”。
    public class ServerSocket : IServerSocket
    {
        public void RegiestForUpdates(string ticket)
        {
            Console.WriteLine("服务器端:{0}-{1}",DateTime.Now,ticket);  
            Update bgWorket = new Update();
            // 获取调用当前操作的客户端实例的通道。
            bgWorket.callBack = OperationContext.Current.GetCallbackChannel<IClientCallBack>();
            Thread t = new Thread(new ThreadStart(bgWorket.SendUpdateToClient));
            t.IsBackground = true;
            t.Start();
        }
    }
    public class Update
    {
        public IClientCallBack callBack = null;
        public void SendUpdateToClient()
        {
            Random r = new Random();
            for (var i = 0; i < 10; i++)
            {
                Thread.Sleep(5000);
                try
                {
                    callBack.PriceUpdate("msft", 100.00 + r.NextDouble());
                }
                catch(Exception ex)
                {
                    Console.WriteLine("Error sending to client:{0}",ex.Message);
                }
            }
        }
    }
}
