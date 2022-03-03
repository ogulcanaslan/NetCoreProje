using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using NetCoreProje.Data;
using NetCoreProje.Models;


namespace NetCoreProje.Controllers
{
    public class UrunlerController : Controller
    {
        private readonly ProjectDBContext _context;
        private readonly IWebHostEnvironment _webHost;

        public UrunlerController(ProjectDBContext context, IWebHostEnvironment webHost)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            List<Urunler> app;
            app = _context.Urunlers.ToList();

            return View(app);
        }


        public IActionResult Create()
        {
            Urunler urunler = new Urunler();
            return View(urunler);
        }

        [HttpPost]
        public IActionResult Create(Urunler urunler)
        {
            _context.Add(urunler);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
        public IActionResult Delete(int id)
        {
            Urunler urun = _context.Urunlers.Find(id);
            _context.Urunlers.Remove(urun);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult Details(int id)
        {
            Urunler urunler = _context.Urunlers.Find(id);
            return View(urunler);
        }

        public IActionResult Edit(int id)
        {
            Urunler urunler = _context.Urunlers.Find(id);
            urunler.AlisFiyat = Convert.ToDecimal(urunler.AlisFiyat);
            urunler.SatisFiyat = Convert.ToDecimal(urunler.SatisFiyat);
            return View(urunler);

        }

        [HttpPost]
        public IActionResult Edit(Urunler urunler)
        {
            
            if (ModelState.IsValid)
            {
                _context.Update(urunler);
               
                _context.SaveChanges();
               
            }
            return RedirectToAction("Index");
        }
    }
}
