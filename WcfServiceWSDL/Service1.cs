using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Threading;

namespace WcfServiceWSDL
{
    // 注意: 使用“重构”菜单上的“重命名”命令，可以同时更改代码和配置文件中的类名“Service1”。
    public class FlyService : IFlyService
    {
        public ResponseMessage Fly(Student stu)
        {
            Console.WriteLine("当前Fly方法接受的参数为: ID={0}, Name={1}", stu.ID, stu.Name);

            return new ResponseMessage()
            {
                Code = 1,
                Message = "服务处理成功！"
            };
        }
    }
}
