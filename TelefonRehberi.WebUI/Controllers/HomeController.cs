using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using TelefonRehberi.Data.Abstract;

namespace TelefonRehberi.WebUI.Controllers
{
    public class HomeController : Controller
    {

        private readonly ICalisanRepository _calisanRepository;
        private readonly IDepartmanRepository _departmanRepository;
        public HomeController(ICalisanRepository calisanRepo , IDepartmanRepository departmanRepo)
        {
            _calisanRepository = calisanRepo;
            _departmanRepository = departmanRepo;
        }
        

       
        public IActionResult Index()
        {
            return View(_calisanRepository.GetAll());
        }

        public IActionResult Detay(int id)
        {
            var b = _calisanRepository.GetAll().Where(i => i.CalisanId == id).Include(i => i.Departman).SingleOrDefault();

            return View(b);
        }
    }
}
