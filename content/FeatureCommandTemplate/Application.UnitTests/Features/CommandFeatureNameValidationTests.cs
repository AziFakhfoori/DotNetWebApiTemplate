using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TopLevelDomain.ProjectName.Application.Features;
using FluentValidation.TestHelper;
using Xunit;

namespace TopLevelDomain.ProjectName.Application.IntegrationTests.Features
{
    public class CommandFeatureNameValidationTests
    {
        private CommandFeatureName.Validator sut;

        public CommandFeatureNameValidationTests()
        {
            this.sut = new CommandFeatureName.Validator();
        }

        /*
        [Fact]
        public void ShouldRequireMinimumFields()
        {
            var command = new CommandFeatureName.Command();
            var result = sut.TestValidate(command);
            result.ShouldHaveValidationErrorFor(x => x.);
        }
        */
    }
}
