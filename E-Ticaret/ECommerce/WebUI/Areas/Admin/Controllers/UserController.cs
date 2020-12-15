using SERVICE.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebUI.Areas.Admin.Controllers
{
    public class UserController : Controller
    {
        AppUserService appUserService = new AppUserService();
        public ActionResult Index()
        {
            return View(appUserService.GetList());
        }

        
    }
}