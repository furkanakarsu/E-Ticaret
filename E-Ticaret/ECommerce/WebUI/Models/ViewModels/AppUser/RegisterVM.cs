using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebUI.Models.ViewModels.AppUser
{
    public class RegisterVM
    {
        [Display(Name="Ad")]
        public string Name { get; set; }
        [Display(Name = "Soyad")]
        public string LastName { get; set; }
        [Required(ErrorMessage ="Email boş geçilemez")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Kullanıcı adı boş geçilemez")]
        [Display(Name = "Kullanıcı Adı")]
        public string UserName { get; set; }
        [Display(Name = "Cinsiyet")]
        public string Gender { get; set; }
        [Required(ErrorMessage = "Şifre boş geçilemez")]
        [Display(Name = "Şifre")]
        public string Password { get; set; }
        [Required(ErrorMessage = "Şifre(Tekrar) boş geçilemez")]
        [Compare("Password",ErrorMessage ="Şifreler uyuşmuyor")]
        [Display(Name = "Şifre(Tekrar)")]
        public string ConfirmPassword { get; set; }
        public Guid ActivationCode { get; set; }

    }
}