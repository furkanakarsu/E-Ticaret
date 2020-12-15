using MODEL.Entities;
using SERVICE.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebUI.Areas.Admin.Controllers
{
    public class SubCategoryController : Controller
    {
        SubCategoryService subCategoryService = new SubCategoryService();
        CategoryService categoryService = new CategoryService();
        public ActionResult Index()
        {
            TempData["Kategori Listesi"] = categoryService.GetList();
            return View(subCategoryService.GetList());
            
        }

        public ActionResult AddSubCategory()
        {
            return View(categoryService.GetList());
        }

        [HttpPost]
        public ActionResult AddSubCategory(SubCategory subCategory, int categoryId)
        {
            subCategory.CategoryId = categoryId;
            subCategoryService.Add(subCategory);
            return RedirectToAction("Index");
        }
    }
}