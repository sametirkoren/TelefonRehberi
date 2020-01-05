using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TelefonRehberi.Data.Abstract;
using TelefonRehberi.Data.Concrete.EfCore;
using TelefonRehberi.Entity;

namespace TelefonRehberi.WebUI.Controllers
{
    public class AdminController : Controller
    {
        private readonly IAdminRepository _adminRepository;
        private readonly ICalisanRepository _calisanRepository;
        private readonly IDepartmanRepository _departmanRepository;
        public AdminController(IAdminRepository adminRepository , ICalisanRepository calisanRepository , IDepartmanRepository departmanRepository)
        {
            _adminRepository = adminRepository ;
            _calisanRepository = calisanRepository;
            _departmanRepository = departmanRepository;
        }

        public IActionResult Index()
        {
            var calisanSayisi = _calisanRepository.GetAll().Select(i => i.CalisanId);
            var departmanSayisi = _departmanRepository.GetAll().Select(i => i.DepartmanId);
            
            ViewBag.calisanSayisi = calisanSayisi.Count();
            ViewBag.departmanSayisi = departmanSayisi.Count();

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

                ViewBag.Hata = "Lütfen Bilgileri Doldurunuz.";
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

        public IActionResult Adminlistele()
        {
            return View(_adminRepository.GetAll());
        }

        public IActionResult Guncelle(int id)
        {
            return View(_adminRepository.GetById(id));
        }
        [HttpPost]
        public IActionResult Guncelle(Admin admin)
        {
            if (ModelState.IsValid)
            {
                _adminRepository.UpdateAdmin(admin);
                TempData["message"] = $"{admin.AdminId} numaralı Admin güncellendi.";
                return RedirectToAction("Adminlistele");
            }
          
            return View(admin);
        }
    }
}