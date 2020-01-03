using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using TelefonRehberi.Data.Abstract;
using TelefonRehberi.Entity;

namespace TelefonRehberi.WebUI.Controllers
{
    public class CalisanController : Controller
    {
        private readonly ICalisanRepository _calisanRepository;
        private readonly IDepartmanRepository _departmanRepository;   
        public CalisanController(ICalisanRepository calisanRepo , IDepartmanRepository departmanRepo)
        {
            _calisanRepository = calisanRepo;
            _departmanRepository = departmanRepo;
        }

        public IActionResult Index()
        {
            return View(_calisanRepository.GetAll().Include(i=>i.Departman));
        }

        public IActionResult Ekle()
        {
            ViewBag.DepartmanId = new SelectList(_departmanRepository.GetAll(), "DepartmanId", "DepartmanAdi");
            ViewBag.YoneticiId = new SelectList(_calisanRepository.GetAll(), "YoneticiId", "CalisanAdi");
            return View();
        }

        [HttpPost]
        public IActionResult Ekle(Calisan calisan)
        {
            if (ModelState.IsValid)
            {
                _calisanRepository.AddCalisan(calisan);
                TempData["message"] = $"{calisan.CalisanAdi } {calisan.CalisanSoyadi} çalışan olarak eklendi.";
                return RedirectToAction("Index");
            }

            ViewBag.DepartmanId = new SelectList(_departmanRepository.GetAll(), "DepartmanId", "DepartmanAdi");
            ViewBag.YoneticiId = new SelectList(_calisanRepository.GetAll(), "YoneticiId", "CalisanAdi");
            return View(calisan);
        }
        [HttpGet]
        public IActionResult Duzenle(int id)
        {
            ViewBag.DepartmanId = new SelectList(_departmanRepository.GetAll(), "DepartmanId", "DepartmanAdi");
            ViewBag.YoneticiId = new SelectList(_calisanRepository.GetAll(), "YoneticiId", "CalisanAdi");

            return View(_calisanRepository.GetById(id));
        }
        [HttpPost]
        public IActionResult Duzenle(Calisan calisan)
        {
            if (ModelState.IsValid)
            {
                _calisanRepository.UpdateCalisan(calisan);
                TempData["message"] = $"{calisan.CalisanAdi} {calisan.CalisanSoyadi} güncellendi.";
                return RedirectToAction("Index");
            }
            ViewBag.YoneticiId = new SelectList(_calisanRepository.GetAll(), "YoneticiId", "CalisanAdi");
            return View(calisan);
        }

        [HttpGet]
        public IActionResult Sil(int id)
        {
            return View(_calisanRepository.GetById(id));
        }

        [HttpPost,ActionName("Sil")]

        public IActionResult SilOnayla(int calisanId)
        {
            _calisanRepository.DeleteCalisan(calisanId);
            TempData["message"] = $"{calisanId} numaralı çalışan silindi.";
            return RedirectToAction("Index");  
        }
    }
}