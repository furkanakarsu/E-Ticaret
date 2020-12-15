using COMMON;
using MODEL.Entities;
using SERVICE.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebUI.Models.Basket;
using WebUI.Models.ViewModels.AppUser;

namespace WebUI.Controllers
{
    public class HomeController : Controller
    {
        AppUserService appUserService = new AppUserService();
        ProductService productService = new ProductService();
        public ActionResult Index()
        {
            var users = appUserService.GetList();
            return View(productService.GetDefault(x=>x.Status==CORE.CoreEntity.Enums.Status.Active)
                .OrderByDescending(x=>x.CreatedDate).ToList());
        }

       public ActionResult Register()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Register(RegisterVM registerVM)
        {
           
            if (ModelState.IsValid)
            {
                var result = appUserService.Any(x => x.Email == registerVM.Email || x.UserName == registerVM.UserName);
                if (result)
                {
                    TempData["Error"] = $"{registerVM.UserName} daha önce kayıt edilmiş";
                }
                else
                {
                    AppUser user = new AppUser();
                    user.UserName = registerVM.UserName;
                    user.Password = registerVM.Password;
                    user.Name = registerVM.Name;
                    user.LastName = registerVM.LastName;
                    user.Gender = registerVM.Gender;
                    user.Email = registerVM.Email;

                    registerVM.ActivationCode = Guid.NewGuid();
                    user.ActivationId = registerVM.ActivationCode;
                    appUserService.Add(user);
                    string message = $"Kullanıcı başarılı şekilde oluşturuldu.\nKayıt işlemini tamamlamak için lütfen aşağıdaki linki tıklayın.\n" + "https://localhost:44319/" + "Home/Complete/" + registerVM.ActivationCode;
                    MailSender.SendEmail(registerVM.Email, "Kayıt İşlemi", message);
                }
                return RedirectToAction("Pending",registerVM);
            }
            else
            {
                return View(registerVM);
            }
           
        }

        public ActionResult Pending(RegisterVM registerVM)
        {
            if (registerVM != null)
            {
                return View(registerVM);
            }
            else
            {
                return RedirectToAction("Index");
            }
            
        }

        public ActionResult Complete(Guid id)
        {
            if (id == null)
            {
                return RedirectToAction("Index");
            }
            else
            {
                var result = appUserService.Any(x => x.ActivationId == id);
                if (result)
                {
                    AppUser user = appUserService.GetDefault(x => x.ActivationId == id).FirstOrDefault();
                    user.IsActive = true;
                    appUserService.Update(user);
                    TempData["Success"] = "Kullanıcı Aktif edildi";
                    return RedirectToAction("Index");
                }
            }
            return View();
        }

        public ActionResult AddToCart(int id)
        {
            CartItem basket = Session["basket"] == null ? new CartItem() : Session["basket"] as CartItem;

            Product eklenecekUrun = productService.GetById(id);
            Cart cart = new Cart();
            cart.ID = eklenecekUrun.Id;
            cart.UnitPrice = eklenecekUrun.UnitPrice;
            cart.ImagePath = eklenecekUrun.ImagePath;
            cart.ProductName = eklenecekUrun.ProductName;
            basket.AddProduct(cart);
            Session["basket"] = basket;

            return RedirectToAction("Index");
        }
    }
}