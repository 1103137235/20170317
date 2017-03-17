using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication3.Controllers
{
    public class OrderController : Controller
    {
        //
        // GET: /Order/
        public ActionResult Index()
        {
            Models.OrderService OrderService=new Models.OrderService();
            var order=OrderService.GetOrderById("111");
            ViewBag.CustId=order.CustId;
            ViewBag.CustName=order.CustName;
            return View();
        }
        public ActionResult InsertOrder()
        {
            return View();
        }
        [HttpPost()]
        public ActionResult InsertOrder(Models.Order order)
        {
            Models.OrderService orderService = new Models.OrderService();
            orderService.InsertOrder(order);
            return View("Index");
        }

    }
}