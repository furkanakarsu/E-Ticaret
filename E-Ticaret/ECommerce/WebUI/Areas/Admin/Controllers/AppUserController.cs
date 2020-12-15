using MODEL.Entities;
using SERVICE.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebUI.Areas.Admin.Controllers
{
    public class AppUserController : Controller
    {
        AppUserService appUserService = new AppUserService();
        // GET: Admin/AppUser
        public ActionResult Index()
        {
            return View(appUserService.GetDefault(x=>x.Status==CORE.CoreEntity.Enums.Status.Active||x.Status==CORE.CoreEntity.Enums.Status.Updated));
        }

        public ActionResult AddAppUser()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddAppUser(AppUser appUser)
        {

            string result = appUserService.Add(appUser);
            TempData["Result"] = result;

            return RedirectToAction("Index");
        }

        public ActionResult DeleteAppUser(int id)
        {

            appUserService.Remove(id);
            return RedirectToAction("Index");
        }

        public ActionResult UpdateAppUser(int id)
        {
            AppUser user = appUserService.GetById(id) as AppUser;

            return View(user);
        }

        [HttpPost]
        public ActionResult UpdateAppUser(AppUser appUser)
        {
            appUserService.Update(appUser);
            return RedirectToAction("Index");
        }
    }
}