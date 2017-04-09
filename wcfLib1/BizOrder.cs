using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace wcfLib1
{
    public class BizOrder : IOrder
    {
        public string GetOrderList()
        {
            List<Order> list= new List<Order>()
            {
                new Order(){Id=1,OrderNum="1001"},
                new Order(){Id=2,OrderNum="1002"},
                new Order(){Id=3,OrderNum="1003"}
            };
            var jsonRes= Newtonsoft.Json.JsonConvert.SerializeObject(list);
            return jsonRes;
        }
    }
}