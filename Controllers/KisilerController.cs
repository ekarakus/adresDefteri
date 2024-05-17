using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using miracApp.Models;

namespace miracApp.Controllers
{
    public class KisilerController : Controller
    {
        private readonly ILogger<KisilerController> _logger;
        private readonly ApplicationDbContext db;
        public KisilerController(ILogger<KisilerController> logger, ApplicationDbContext _db)
        {
            _logger = logger;
            db = _db;
        }
        [HttpGet]
        public IActionResult Ekle()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Ekle(Kisi model)
        {
            if (ModelState.IsValid)
            {
                db.Kisiler.Add(model);
                db.SaveChanges();
                ViewBag.mesaj="Kişi Kaydedildi";
            }
            return View();
        }
        public IActionResult Liste()
        {         
            var liste=db.Kisiler.ToList();            
            return View(liste);
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View("Error!");
        }
    }
}