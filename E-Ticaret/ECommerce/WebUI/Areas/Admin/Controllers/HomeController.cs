using SERVICE.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebUI.Areas.Admin.Controllers
{

    public class HomeController : Controller
    {

        OrderService _orderService = new OrderService();
        ProductService _productService = new ProductService();
        AppUserService _userService = new AppUserService();
        OrderDetailService _orderDetailService = new OrderDetailService();

        public ActionResult Index()
        {
            ViewData["ToplamSiparis"] = _orderService.GetList().Count();
            ViewData["ToplamÜrün"] = _productService.GetList().Count();
            ViewData["ToplamKullanici"] = _userService.GetList().Count();
            decimal fiyat=0;
            foreach (var item in _orderDetailService.GetList())
            {
                if (fiyat < item.UnitPrice)
                {
                    fiyat = item.UnitPrice;
                }
            }
            ViewData["EnYuksekFiyat"] = fiyat;
            return View();
        }
    }
}