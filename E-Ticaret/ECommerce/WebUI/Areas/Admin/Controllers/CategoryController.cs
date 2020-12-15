using MODEL.Entities;
using SERVICE.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebUI.Areas.Admin.Controllers
{
    public class CategoryController : Controller
    {
        CategoryService categoryService = new CategoryService();

        
        public ActionResult Index()
        {
            return View(categoryService.GetList());
        }

        public ActionResult AddCategory()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddCategory(Category category)
        {
            string result = categoryService.Add(category);
            TempData["Result"] = result;

            return RedirectToAction("Index");
        }

        //View ini kullanmamiza gerek olmadigi icin Herhangi bir DeleteCategoryView olusturmuyorum.
        public ActionResult DeleteCategory(int id)
        {
            
            categoryService.Remove(id);
            return RedirectToAction("Index");

        }
        //Update category View inin icerisine Add category deki html kodlarini attim fakat @html.TextBoxFor larin icerisine placeholder verip guncelleyecegim Category item'in bilgilerini yolladim. (CategoryName ve Description)
        public ActionResult UpdateCategory(int id)
        {
            Category item = categoryService.GetById(id) as Category;
            return View(item);
        }
        
        //Form grup ayni sekilde addcategory deki oldugu icin Category cekebildim. Ve gerisini categoryService.Update() metodu halletti.

        [HttpPost]
        public ActionResult UpdateCategory(Category category)
        {
            categoryService.Update(category);
            return RedirectToAction("Index");
        }

        //todo: Category Güncelleme

        //todo: Category Silme
    }
}