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
    public class ReyonlarController : Controller
    {

        private readonly ProjectDBContext _context;
        private readonly IWebHostEnvironment _webHost;

        public ReyonlarController(ProjectDBContext context, IWebHostEnvironment webHost)
        {
            _context = context;
        }


        public IActionResult Index()
        {
            List<Reyonlar> app;
            app = _context.Reyonlars.ToList();

            return View(app);
        }
    
        public IActionResult Create()
        {
            Reyonlar reyonlar = new Reyonlar();
            return View(reyonlar);
        }

        [HttpPost]
        public IActionResult Create(Reyonlar reyonlar)
        {
            _context.Add(reyonlar);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
