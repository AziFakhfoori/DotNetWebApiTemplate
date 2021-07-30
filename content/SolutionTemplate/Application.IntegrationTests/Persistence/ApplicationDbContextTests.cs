using Microsoft.EntityFrameworkCore;
using Moq;
using System;
using TopLevelDomain.ProjectName.Application.Common.Interfaces;
using TopLevelDomain.ProjectName.Infrastructure;

namespace TopLevelDomain.ProjectName.Application.IntegrationTests.Persistence
{
    public class ApplicationDbContextTests : IDisposable
    {
        private readonly DateTime dateTime;
        private readonly Mock<IDateTime> dateTimeMock;
        private readonly ApplicationDbContext sut;

        public ApplicationDbContextTests()
        {
            dateTime = new DateTime(3001, 1, 1);
            dateTimeMock = new Mock<IDateTime>();
            dateTimeMock.Setup(m => m.UtcNow).Returns(dateTime);

            var options = new DbContextOptionsBuilder<ApplicationDbContext>()
                .UseInMemoryDatabase(Guid.NewGuid().ToString())
                .Options;

            sut = new ApplicationDbContext(options, dateTimeMock.Object);
        }

        public void Dispose()
        {
            sut?.Dispose();
        }
    }
}
