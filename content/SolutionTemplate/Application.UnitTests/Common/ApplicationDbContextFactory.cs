using Microsoft.EntityFrameworkCore;
using Moq;
using System;
using TopLevelDomain.ProjectName.Application.Common.Interfaces;
using TopLevelDomain.ProjectName.Infrastructure;

namespace TopLevelDomain.ProjectName.Application.UnitTests.Common
{
    public class ApplicationDbContextFactory
    {
        public static ApplicationDbContext Create()
        {
            var options = new DbContextOptionsBuilder<ApplicationDbContext>()
                .UseInMemoryDatabase(Guid.NewGuid().ToString())
                .Options;

            var dateTime = new DateTime(3001, 1, 1);
            var dateTimeMock = new Mock<IDateTime>();
            dateTimeMock.Setup(m => m.UtcNow).Returns(dateTime);

            var context = new ApplicationDbContext(options, dateTimeMock.Object);

            // Init any seed data here
            //context.SaveChanges();

            return context;
        }

        public static void Destroy(ApplicationDbContext context)
        {
            context.Database.EnsureDeleted();

            context.Dispose();
        }
    }
}
