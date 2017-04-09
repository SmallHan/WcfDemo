using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;

namespace WcfSelfhosting
{
    public class SelfHosting
    {
        static void Main()
        {
            //
            // 摘要: 
            //     使用服务的类型及其指定的基址初始化 System.ServiceModel.ServiceHost 类的新实例。
            //
            // 参数: 
            //   serviceType:
            //     承载服务的类型。  表示要托管的wcf服务的实现类的Type类型
            //
            //   baseAddresses:
            //     System.Uri 类型的数组，包含承载服务的基址。 表示当前wcf服务监听的url，如果没有填写的话则默认到webconfig中去寻找
            //
            /*
             * public ServiceHost(Type serviceType, params Uri[] baseAddresses);
             *创建ServiceHost对象时，需要为ServiceHost的构造函数提供服务类型，默认的基地址是可选的，
             * 可以将基地址设置为空（从配置文件里面获取）。ServiceHost拥有基地址集合可以使得服务能够接收多个地址和协议的
             * 调用。
            */
            using (ServiceHost sh = new ServiceHost(typeof(Service1)))
            {
                //开启主机环境
                /*
                 * 打开宿主进程（所谓的宿舍进程就是说 wcf服务类不能凭空存在，每个WCF服务都必须托管在Windows进程中，在Windows进程中，
                  * 该进程被称为宿主进程)
                ）*/
                sh.Open();
                Console.WriteLine("wcf1服务services1已经启动。。。");
                Console.ReadKey();
            }
        }
    }
}
