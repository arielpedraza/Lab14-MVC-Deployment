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

        [Fact]
        public void TestHomeIndexReturnsView()
        {
            using (_context = new MutantDbContext(options))
            {
                // Arrange
                HomeController controller = new HomeController(_context);
                // Act
                var result = controller.Index();
                // Assert
                Assert.NotNull(result);
            }
        }
    }
}
