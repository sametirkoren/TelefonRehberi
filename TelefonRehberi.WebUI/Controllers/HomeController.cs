using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using TelefonRehberi.Data.Abstract;
using TelefonRehberi.WebUI.Models;

namespace TelefonRehberi.WebUI.Controllers
{
    public class HomeController : Controller
    {

        private readonly ICalisanRepository calisanRepository;

        public HomeController(ICalisanRepository repository)
        {
            calisanRepository = repository;
        }
        

       
        public IActionResult Index()
        {
            return View(calisanRepository.GetAll());
        }

      
    }
}
