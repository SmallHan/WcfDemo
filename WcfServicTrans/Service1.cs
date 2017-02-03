using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using Dapper;
using System.Transactions;

namespace WcfServicTrans
{
    // 注意: 使用“重构”菜单上的“重命名”命令，可以同时更改代码和配置文件中的类名“Service1”。
    public class FlyService : IFlyService
    {
        /// <summary>
        /// TransactionScopeRequired  是否开启事务
        /// TransactionAutoComplete   是否自动提交
        /// </summary>
        /// <param name="msg"></param>
        [OperationBehavior(TransactionScopeRequired = true, TransactionAutoComplete = true)]
        public void Inovke(string msg)
        {

            string sqlConn = "server=localhost;User Id=root;password=hbk12593;Database=mydb;MaxPoolSize=5";
            var conn = new MySql.Data.MySqlClient.MySqlConnection(sqlConn);

            using (TransactionScope trans = new TransactionScope())
            {
                try
                {
                    conn.Open();
                    var r = conn.Execute("insert tab_userinfo(Name) values(@name)",
                           new[]{
                        new {Name="小瀚"}
                    });
                    Console.WriteLine(r);
                    trans.Complete();
                }
                catch(Exception ex)
                {
                    Console.WriteLine("\n异常信息:\n{0}", ex.Message);
                }
                finally
                {
                    conn.Close();
                    conn.Dispose();
                }
            }
        }
    }
}
