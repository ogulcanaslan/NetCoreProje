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
    public class PersonelController : Controller
    {
        private readonly ProjectDBContext _context;
        private readonly IWebHostEnvironment _webHost;

        public PersonelController(ProjectDBContext context, IWebHostEnvironment webHost)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            List<Personel> app;
            app = _context.Personels.ToList();
            return View(app);
        }

        public IActionResult Create()
        {
            Personel personel = new Personel();
            return View(personel);
        }
        [HttpPost]
        public IActionResult Create(Personel personel)
        {
            _context.Add(personel);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
