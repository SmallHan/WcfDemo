using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Description;
using System.Text;
using System.Threading.Tasks;

namespace WcfServiceLHost
{
    class Program
    {
        static void Main(string[] args)
        {
            #region
            //// <host>
            //// <baseAddresses>
            ////   <add baseAddress="http://localhost:8733/MyService" />
            //// </baseAddresses>
            ////</host>
            //ServiceHost host = new ServiceHost(typeof(Service1), new Uri("http://localhost:8733/MyService/"));
            ////这是我们服务的地址

            //// <endpoint address="" binding="basicHttpBinding" contract="WcfServiceConfig.IFlyService">
            //// <identity>
            //// <dns value="localhost" />
            ////  </identity>
            ////</endpoint>
            //host.AddServiceEndpoint(typeof(IService1), new BasicHttpBinding(), string.Empty);

            ////mex元数据的地址
            //// <endpoint address="mex" binding="mexHttpBinding" contract="IMetadataExchange" />
            //host.AddServiceEndpoint(typeof(IMetadataExchange), MetadataExchangeBindings.CreateMexHttpBinding(), "mex");
            ////host.AddServiceEndpoint(typeof(IMetadataExchange), MetadataExchangeBindings.CreateMexHttpBinding(), "mex");
            //// <behaviors>
            ////  <serviceBehaviors>
            ////    <behavior name="">
            ////      <serviceMetadata httpGetEnabled="true" httpsGetEnabled="true" />
            ////      <serviceDebug includeExceptionDetailInFaults="false" />
            //// </behavior>
            ////  </serviceBehaviors>
            ////</behaviors>
            ////host.Description.Behaviors.Add(new ServiceMetadataBehavior() { HttpGetEnabled = true, HttpsGetEnabled = true });
            ////var single = host.Description.Behaviors.Find<ServiceDebugBehavior>();
            ////single.IncludeExceptionDetailInFaults = false;
            //host.Open();
            //Console.WriteLine("WCF开启！");
            //Console.ReadKey();
            #endregion

            //// <host>
            //// <baseAddresses>
            ////   <add baseAddress="http://localhost:8733/MyService" />
            //// </baseAddresses>
            ////</host>
            ServiceHost host = new ServiceHost(typeof(Service1), new Uri("http://localhost:8733/MyService/"));

            //// <endpoint address="" binding="basicHttpBinding" contract="WcfServiceConfig.IFlyService">
            //// <identity>
            //// <dns value="localhost" />
            ////  </identity>
            ////</endpoint>
            //这是我们服务的地址
            host.AddServiceEndpoint(typeof(IService1), new BasicHttpBinding(), string.Empty);

            //// <behaviors>
            ////  <serviceBehaviors>
            ////    <behavior name="">
            ////      <serviceMetadata httpGetEnabled="true" httpsGetEnabled="true" />
            ////      <serviceDebug includeExceptionDetailInFaults="false" />
            //// </behavior>
            ////  </serviceBehaviors>
            ////</behaviors>
            //mex元数据的地址
            host.Description.Behaviors.Add(new ServiceMetadataBehavior() { HttpGetEnabled = true });

            //<endpoint address="mex" binding="mexHttpBinding" contract="IMetadataExchange" />
            //mex元数据的地址
            host.AddServiceEndpoint(typeof(IMetadataExchange), MetadataExchangeBindings.CreateMexHttpBinding(), "mex");

            host.Open();

            Console.WriteLine("WCF 服务开启");

            Console.Read();
        }
    }
}
