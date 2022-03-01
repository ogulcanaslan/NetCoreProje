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
    }
}
