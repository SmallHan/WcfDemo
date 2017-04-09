using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WcfPerSession
{
    // 默认是PerSession和Single
    [ServiceContract]
    public interface ISocketService
    {
        [OperationContract]
        double GetPrice(string ticket);
    }

}
