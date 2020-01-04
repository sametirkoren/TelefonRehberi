using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TelefonRehberi.Data.Abstract;
using TelefonRehberi.Entity;

namespace TelefonRehberi.WebUI.Controllers
{

    public class DepartmanController : Controller
    {
        private readonly IDepartmanRepository _departmanRepository;
        private readonly ICalisanRepository _calisanRepository;
      
       
        public DepartmanController(IDepartmanRepository departmanRepo , ICalisanRepository calisanRepo )
        {
            
            _departmanRepository = departmanRepo;
            _calisanRepository = calisanRepo;
            
            
        }

        public IActionResult Index()
        {
            return View(_departmanRepository.GetAll());
        }

        [HttpGet]
        public IActionResult Ekle()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Ekle(Departman departman)
        {
            if (ModelState.IsValid)
            {
                _departmanRepository.AddDepartman(departman);
                TempData["message"] = $"{departman.DepartmanAdi} departman olarak eklendi.";
                return RedirectToAction("Index");
            }
            return View(departman);
        }

        public IActionResult Duzenle(int id)
        {
            return View(_departmanRepository.GetById(id));
        }

        [HttpPost]
        public IActionResult Duzenle(Departman departman)
        {
            if (ModelState.IsValid)
            {
                _departmanRepository.UpdateDepartman(departman);
                TempData["message"] = $"{departman.DepartmanAdi} güncellendi.";
                return RedirectToAction("Index");
            }
            
            return View(departman);
        }

        [HttpGet]
        public IActionResult Sil (int id)
        {
            return View(_departmanRepository.GetById(id));
        }



        [HttpPost, ActionName("Sil")]

        public IActionResult SilOnayla(int departmanId)
        {
            var b = _departmanRepository.GetAll().Where(i => i.DepartmanId == departmanId).Include(i => i.Calisanlar).SingleOrDefault();

            if(b.Calisanlar.Count() == 0)
            {
                _departmanRepository.DeleteDepartman(departmanId);
                TempData["message"] = $"{departmanId} numaralı departman silindi.";
                return RedirectToAction("Index");
            }

            TempData["message"] = $"{departmanId} numaralı Bu departmanı silemezsiniz! Bu departmanda çalışanlar var.";
            return RedirectToAction("Index");
        }


    }
}