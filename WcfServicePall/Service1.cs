﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Threading;

namespace WcfServicePall
{
    // 注意: 使用“重构”菜单上的“重命名”命令，可以同时更改代码和配置文件中的类名“Service1”。
     [ServiceBehavior(InstanceContextMode = InstanceContextMode.PerSession, ConcurrencyMode = ConcurrencyMode.Single)]
    public class FlyService : IFlyService
    {
        public FlyService()
        {
            Console.WriteLine("我是构造函数:{0},时间为:{1}",Thread.CurrentThread.ManagedThreadId,DateTime.Now);
        }
        //wsHttpBinding 支持会话，如果当前没有重新
        int nums=0;
        public string Inovke(string msg)
        {
            Console.WriteLine("当前的nums={0},threading={1},time={2}", ++nums, Thread.CurrentThread.ManagedThreadId, DateTime.Now);

            Thread.Sleep(1000 * 5);

            return string.Empty;
        }
    }
}