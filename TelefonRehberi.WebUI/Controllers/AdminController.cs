using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TelefonRehberi.Data.Abstract;
using TelefonRehberi.Data.Concrete.EfCore;
using TelefonRehberi.Entity;

namespace TelefonRehberi.WebUI.Controllers
{
    public class AdminController : Controller
    {
        private readonly IAdminRepository _adminRepository;
        public AdminController(IAdminRepository adminRepository)
        {
            _adminRepository = adminRepository ;
            
        }

        public IActionResult Index()
        {
            return View();
        }
        
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(Admin admin)
        {
            var login = _adminRepository.Kontrol(admin);

           if(login == null)
            {

                ViewBag.Uyari = "Kullanıcı Adı veya Şifreniz Hatalı";
            }

           else if(login.Eposta == admin.Eposta && login.Sifre == admin.Sifre)
            {
                HttpContext.Session.SetString("Eposta", login.Eposta);
                HttpContext.Session.SetInt32("AdminId", login.AdminId);
                
                return RedirectToAction("Index", "Admin");

            }
           
            ViewBag.Uyari = "Eposta yada şifre yanlış.";
            return View(admin);
        }

        public IActionResult Logout()
        {
            
            HttpContext.Session.Remove("Eposta");
            HttpContext.Session.Remove("AdminId");
            HttpContext.Session.Clear();
            return RedirectToAction("Login", "Admin");
        }
    }
}