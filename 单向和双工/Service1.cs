using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Threading;

namespace 单向和双工
{
    // 注意: 使用“重构”菜单上的“重命名”命令，可以同时更改代码和配置文件中的类名“Service1”。
    public class Fly : IFlyService
    {

        public void DoBigAnalysisFast(string ticket)
        {
            Thread.Sleep(5000);
            Console.WriteLine("单向"+DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")+ticket);
        }

        public void DoBigAnalysisSlow(string ticket)
        {
            Thread.Sleep(5000);
            Console.WriteLine(DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")+ticket);
        }
    }
}
