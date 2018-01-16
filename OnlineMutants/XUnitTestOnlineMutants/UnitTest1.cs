using OnlineMutants.Data;
using OnlineMutants.Controllers;
using OnlineMutants.Models;
using Microsoft.EntityFrameworkCore;
using System;
using Xunit;

namespace XUnitTestOnlineMutants
{
    public class UnitTest1
    {
        MutantDbContext _context;

        public UnitTest1()
        {
            DbContextOptionsBuilder<MutantDbContext> builder = new DbContextOptionsBuilder<MutantDbContext>();
            builder.UseInMemoryDatabase(Guid.NewGuid().ToString());
            DbContextOptions<MutantDbContext> options = builder.Options;
            _context = new MutantDbContext(options);
        }

        [Fact]
        public void Test1()
        {

        }
    }
}
