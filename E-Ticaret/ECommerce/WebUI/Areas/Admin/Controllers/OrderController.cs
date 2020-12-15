using SERVICE.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebUI.Areas.Admin.Controllers
{
    public class OrderController : Controller
    {
        OrderService orderService = new OrderService();
        public ActionResult Index()
        {
            return View(orderService.GetList());
        }
    }
}