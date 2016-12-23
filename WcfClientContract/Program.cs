using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WcfClientContract.ServiceReference1;

namespace WcfClientContract
{
    class Program
    {
        static void Main(string[] args)
        {
            ServiceReference1.FlyServiceClient flyClient = new ServiceReference1.FlyServiceClient();
            Console.WriteLine("开始调用:{0}",DateTime.Now);
            //第一种
            //string res = flyClient.Fly("Hello World");
            //Console.WriteLine("结束访问:{0}",res);
            //第二种
            flyClient.BeginFly("hello World", new AsyncCallback((obj) =>
            {
                var myClient = (FlyServiceClient)obj.AsyncState;
                string res = myClient.EndFly(obj);
                Console.WriteLine("调用结束:{0}", res);
            }), flyClient);

            //第一种
            //Task.Factory.StartNew(() =>
            //{
            //    string res = flyClient.Fly("Hello World");
            //    Console.WriteLine("子线程访问:{0}",res);
            //});

            //第三种
            //注册一个完成事件
            //flyClient.FlyCompleted += (obj, e) =>
            //{
            //    Console.WriteLine("调用结束:{0}",e.Result);
            //};
            //flyClient.FlyAsync("Hello World");
            Console.WriteLine("结束调用:{0}", DateTime.Now);
            Console.ReadKey();
        }
    }
}
