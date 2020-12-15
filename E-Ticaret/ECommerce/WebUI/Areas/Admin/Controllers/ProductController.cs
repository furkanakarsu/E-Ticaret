using COMMON;
using MODEL.Entities;
using SERVICE.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebUI.Areas.Admin.Controllers
{
    public class ProductController : Controller
    {
        ProductService productService = new ProductService();
        SubCategoryService SubCategoryService = new SubCategoryService();
        public ActionResult Index()
        {
            TempData["Alt Kategoriler"] = SubCategoryService.GetList();
            return View(productService.GetList());
        }

        public ActionResult AddProduct()
        {

            TempData["SubCategories"] = SubCategoryService.GetList();
            return View();
        }
        [HttpPost]
        public ActionResult AddProduct(Product product, HttpPostedFileBase productImage)
        {

            
            product.ImagePath = ImageUploader.UploadImage("~/Content/images/product-images/", productImage);
            if (product.ImagePath == "0")
            {
                TempData["Error"] = "dosya boş";
            }
            else if (product.ImagePath == "1")
            {
                TempData["Error"] = "bu görsel zaten kayıtlı";
            }
            else if (product.ImagePath == "2")
            {
                TempData["Error"] = "belirtilen uzantılara uymuyor (jpg,jpeg,png,gif)";
            }
            else
            {
                string result = productService.Add(product);
                TempData["Result"] = result;
                return RedirectToAction("Index");
            }
            return View();

        }

        //todo: Güncelleme

        //todo: Silme
    }
}