using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebUI.Controllers
{
    public class ShoppingCartController : Controller
    {
        // GET: ShoppingCart
        public ActionResult Index()
        {
            if (Session["basket"] != null)
            {
                return View();
            }
            else
            {
                return RedirectToAction("Index", "Home");
            }

        }
    }
}