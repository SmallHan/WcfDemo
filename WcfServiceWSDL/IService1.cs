using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WcfServiceWSDL
{
    // 注意: 使用“重构”菜单上的“重命名”命令，可以同时更改代码和配置文件中的接口名“IService1”。
    [ServiceContract]
    public interface IFlyService
    {
        [OperationContract]
        ResponseMessage Fly(Student stu);
    }
    public class Student
    {
        public int ID { get; set; }
        public string Name { get; set; }
    }
    public class ResponseMessage
    {
        public int Code { get; set; }
        public string Message { get; set; }
    }
}
