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
    public class CommandFeatureNameTests
    {
        private CommandFeatureName.Handler sut;

        public CommandFeatureNameTests()
        {
            var mockLogger = new Mock<ILogger<CommandFeatureName.Handler>>();

            this.sut = new CommandFeatureName.Handler(mockLogger.Object);
        }        
    }
}
