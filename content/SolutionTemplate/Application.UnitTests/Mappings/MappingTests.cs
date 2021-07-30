using AutoMapper;
using System;
using System.Runtime.Serialization;
using Xunit;

namespace TopLevelDomain.ProjectName.Application.UnitTests.Mappings
{
    public class MappingTests
    {
        private IConfigurationProvider configurationProvider;
        private IMapper mapper;

        public MappingTests()
        {
            this.configurationProvider = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile<Application.Common.Mappings.MappingProfile>();
            });

            this.mapper = configurationProvider.CreateMapper();
        }

        /* Enable to test mappings

        [Fact]
        public void ShouldHaveValidConfiguration()
        {
            configurationProvider.AssertConfigurationIsValid();
        }

        [Theory]
        [InlineData(typeof(" {Entity Name} "), typeof(" {Dto/Model Name } "))]
        public void ShouldSupportMappingFromSourceToDestination(Type source, Type destination)
        {
            var instance = GetInstanceOf(source);
            mapper.Map(instance, source, destination);

            var reverseInstance = GetInstanceOf(destination);
            mapper.Map(reverseInstance, destination, source);
        }
        */

        private object GetInstanceOf(Type type)
        {
            if (type.GetConstructor(Type.EmptyTypes) != null)
                return Activator.CreateInstance(type);

            return FormatterServices.GetUninitializedObject(type);
        }
    }
}
