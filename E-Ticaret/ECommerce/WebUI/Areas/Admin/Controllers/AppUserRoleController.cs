using MODEL.Entities;
using SERVICE.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebUI.Areas.Admin.Controllers
{
    public class AppUserRoleController : Controller
    {
        AppUserRoleService appUserRoleService = new AppUserRoleService();

        

        // GET: Admin/AppUserRole
        public ActionResult Index()
        {
            return View(appUserRoleService.GetList());
        }

        public ActionResult AddAppUserRole()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddAppUserRole(AppUserRole role)
        {
            
            string result = appUserRoleService.Add(role);
            TempData["Result"] = result;

            return RedirectToAction("Index");


        }

        public ActionResult UpdateAppUserRole(int id)
        {
            AppUserRole item = appUserRoleService.GetById(id) as AppUserRole;
            return View(item);
        }

        [HttpPost]
        public ActionResult UpdateAppUserRole(AppUserRole appUserRole)
        {
            appUserRoleService.Update(appUserRole);
            return RedirectToAction("Index");
        }

    }
}

