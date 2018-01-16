using Microsoft.EntityFrameworkCore;
using OnlineMutants.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineMutants.Data
{
    public class MutantDbContext : DbContext
    {
        public MutantDbContext(DbContextOptions<MutantDbContext> options) : base(options)
        {

        }

        public DbSet<Mutant> MutantTable { get; set; }
    }
}
