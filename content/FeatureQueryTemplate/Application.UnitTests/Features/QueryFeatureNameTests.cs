using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TopLevelDomain.ProjectName.Application.Features;
using FluentValidation.TestHelper;
using Xunit;
using Moq;
using FluentAssertions;
using AutoFixture;
using Microsoft.Extensions.Logging;

namespace TopLevelDomain.ProjectName.Application.IntegrationTests.Features
{
    public class QueryFeatureNameTests
    {
        private QueryFeatureName.Handler sut;

        public QueryFeatureNameTests()
        {
            var mockLogger = new Mock<ILogger<QueryFeatureName.Handler>>();

            this.sut = new QueryFeatureName.Handler(mockLogger.Object);
        }
    }
}
