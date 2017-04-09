using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ServiceModel;

namespace wcfLib1
{
    [ServiceContract] //标注当前接口为wcf服务
    public interface IOrder
    {
        [OperationContract]//标注此方法是一个wcf的服务方法，可以被外部调用
        string GetOrderList();
    }
}