using PerSessionClient.ServiceReference1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace PerSessionClient
{
    class Program
    {
        static int c = 0;
        static void Main(string[] args)
        {
            SocketServiceClient proxy = new SocketServiceClient();
            /*
             * 预计结果：服务器端默认是 PerSession，Single，但是绑定的是basichttpbinding，不支持会话，
             * 所以会变为 PerCall，即一次请求创建一个对象
             */
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("{0}-Invoke GetPrice Method",DateTime.Now);
                proxy.BeginGetPrice("SmallHan", GetPriceCallback, proxy);
                Thread.Sleep(100);
                Interlocked.Decrement(ref c);
            }
            while (c > 0)
            {
                Thread.Sleep(100);
            }
            Console.ReadKey();
        }
        static void GetPriceCallback(IAsyncResult ar)
        {
            double price = ((SocketServiceClient)ar.AsyncState).EndGetPrice(ar);
            Console.WriteLine("{0}-{1}", DateTime.Now, price);
            // 以原子操作的形式递减指定变量的值并存储结果。 同步
            Interlocked.Decrement(ref c);
        }
    }
}
