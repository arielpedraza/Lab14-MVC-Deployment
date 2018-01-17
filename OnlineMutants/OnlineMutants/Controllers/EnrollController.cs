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
    public class EnrollController : Controller
    {
        private MutantDbContext _context;

        public EnrollController(MutantDbContext context)
        {
            _context = context;
        }

        // GET: /<controller>/
        public IActionResult ViewAll()
        {
            IEnumerable<Mutant> allMutants = _context.MutantTable;
            return View(allMutants);
        }

        [HttpGet]
        public IActionResult Details(int id)
        {
            return View(_context.MutantTable.FirstOrDefault(m => m.Id == id));
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            return View(_context.MutantTable.FirstOrDefault(m => m.Id == id));
        }

        [HttpPost]
        public IActionResult Edit(Mutant mutant)
        {
            _context.Update(mutant);
            _context.SaveChanges();
            return RedirectToAction("ViewAll");
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            return View(_context.MutantTable.FirstOrDefault(m => m.Id == id));
        }

        [HttpPost]
        public IActionResult Delete(Mutant mutant)
        {
            _context.Remove(mutant);
            _context.SaveChanges();
            return RedirectToAction("ViewAll");
        }
    }
}
