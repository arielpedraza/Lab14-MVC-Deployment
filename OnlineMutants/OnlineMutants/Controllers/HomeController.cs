using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using OnlineMutants.Data;
using OnlineMutants.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

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

        public async Task<IActionResult> OnPostAsync(Mutant mutant)
        {
            if (!ModelState.IsValid) { return View(); }
            _context.MutantTable.Add(mutant);
            await _context.SaveChangesAsync();
            return RedirectToPage("/");
        }

        public async Task OnGetAsync()
        {
            IList<Mutant> mutants = await _context.MutantTable.AsNoTracking().ToListAsync();
        }
    }
}
