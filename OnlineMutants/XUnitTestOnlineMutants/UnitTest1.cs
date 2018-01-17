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

        DbContextOptions<MutantDbContext> options = new DbContextOptionsBuilder<MutantDbContext>()
                                                        .UseInMemoryDatabase(Guid.NewGuid().ToString())
                                                        .Options;
        Mutant mutant = new Mutant
        {
            RealName ="Scott Summers",
            Alias ="Cyclops",
            Powers ="Concussive Optic Blasts",
            Team ="X-Men"
        };

        [Fact]
        public void TestHomeIndexReturnsView()
        {
            using (_context = new MutantDbContext(options))
            {
                _context.MutantTable.Add(mutant);
                _context.SaveChanges();
                // Arrange
                HomeController controller = new HomeController(_context);
                // Act
                var result = controller.Index();
                // Assert
                Assert.NotNull(result);
            }
        }

        [Fact]
        public void TestEnrollViewAllReturnsView()
        {
            using (_context = new MutantDbContext(options))
            {
                _context.MutantTable.Add(mutant);
                _context.SaveChanges();
                // Arrange
                EnrollController controller = new EnrollController(_context);
                // Act
                var result = controller.ViewAll();
                // Assert
                Assert.NotNull(result);
            }
        }

        [Fact]
        public void TestEnrollDetailsReturnsView()
        {
            using (_context = new MutantDbContext(options))
            {
                _context.MutantTable.Add(mutant);
                _context.SaveChanges();
                // Arrange
                EnrollController controller = new EnrollController(_context);
                // Act
                var result = controller.Details(0);
                // Assert
                Assert.NotNull(result);
            }
        }

        [Fact]
        public void TestEnrollEditReturnsView()
        {
            using (_context = new MutantDbContext(options))
            {
                _context.MutantTable.Add(mutant);
                _context.SaveChanges();
                // Arrange
                EnrollController controller = new EnrollController(_context);
                // Act
                var result = controller.Edit(0);
                // Assert
                Assert.NotNull(result);
            }
        }

        [Fact]
        public void TestEnrollDeleteReturnsView()
        {
            using (_context = new MutantDbContext(options))
            {
                _context.MutantTable.Add(mutant);
                _context.SaveChanges();
                // Arrange
                EnrollController controller = new EnrollController(_context);
                // Act
                var result = controller.Delete(0);
                // Assert
                Assert.NotNull(result);
            }
        }
    }
}
