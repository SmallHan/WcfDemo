using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace 双工服务契约
{
    // 注意: 使用“重构”菜单上的“重命名”命令，可以同时更改代码和配置文件中的接口名“IService1”。
    [ServiceContract(CallbackContract=typeof(IClientCallBack))]
    public interface IServerSocket
    {
        [OperationContract(IsOneWay = true)]
        void RegiestForUpdates(string ticket);

    }
    [ServiceContract]
    public interface IClientCallBack
    {
        [OperationContract]
        void PriceUpdate(string ticket, double price);
    }
}
