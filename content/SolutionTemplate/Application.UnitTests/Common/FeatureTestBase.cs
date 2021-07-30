using AutoFixture;
using AutoMapper;
using System;
using TopLevelDomain.ProjectName.Infrastructure;

namespace TopLevelDomain.ProjectName.Application.UnitTests.Common
{
    public class FeatureTestBase : IDisposable
    {
        protected readonly ApplicationDbContext context;
        protected readonly Fixture fixture;
        protected readonly IMapper mapper;

        public FeatureTestBase()
        {
            this.fixture = new Fixture();
            this.context = ApplicationDbContextFactory.Create();
            this.mapper = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile<Application.Common.Mappings.MappingProfile>();
            }).CreateMapper();
        }

        public void Dispose()
        {
            ApplicationDbContextFactory.Destroy(context);
        }
    }
}
