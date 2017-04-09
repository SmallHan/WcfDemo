using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Threading;

namespace WcfPerSession
{
    // 注意: 使用“重构”菜单上的“重命名”命令，可以同时更改代码和配置文件中的类名“Service1”。

    //单实例，多线程
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.Single, ConcurrencyMode = ConcurrencyMode.Single)]
    public class SocketService : ISocketService
    {
         SocketService()
        {
            Console.WriteLine("{0} 我是构造函数",DateTime.Now);
        }
        

        public double GetPrice(string ticket)
        {
            Console.WriteLine("{0}-{1}",DateTime.Now,Thread.CurrentThread.ManagedThreadId);
            Thread.Sleep(5000);
            return 94.85;
        }
    }
}
