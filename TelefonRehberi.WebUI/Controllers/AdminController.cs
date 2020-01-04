using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TelefonRehberi.Data.Concrete.EfCore;
using TelefonRehberi.Entity;

namespace TelefonRehberi.WebUI.Controllers
{
    public class AdminController : Controller
    {
        TelefonRehberiContext db = new TelefonRehberiContext();
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
            var login = db.Admin.Where(x => x.Eposta == admin.Eposta).SingleOrDefault();

            
            return View();
        }
    }
}