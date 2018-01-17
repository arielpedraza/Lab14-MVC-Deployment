using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using OnlineMutants.Data;
using OnlineMutants.Models;

namespace OnlineMutants.Controllers
{
    public class HomeController : Controller
    {
        private MutantDbContext _context;

        public HomeController(MutantDbContext context)
        {
            _context = context;
        }
        
        // GET: /<controller>/
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(Mutant mutant)
        {
            _context.MutantTable.Add(mutant);
            _context.SaveChanges();
            return RedirectToAction("ViewAll", "Enroll");
        }
    }
}
