using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication3.Models
{
    public class OrderService
    {
        public void InsertOrder(Models.Order order)
        {
        }
        public Models.Order GetOrderById(string orderId)
        {
            Models.Order result = new Order();
            result.CustId = "GSS";
            result.CustName = "叡揚資訊";
            return result;
        }
        public void DeleteOrderById(string orderId)
        {
        }
        public void UpdateOrder(Models.Order order)
        {
        }

    }
}