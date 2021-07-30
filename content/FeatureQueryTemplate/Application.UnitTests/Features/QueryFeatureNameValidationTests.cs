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
    public class QueryFeatureNameValidationTests
    {
        private QueryFeatureName.Validator sut;

        public QueryFeatureNameValidationTests()
        {
            this.sut = new QueryFeatureName.Validator();
        }

        /*
        [Fact]
        public void ShouldRequireMinimumFields()
        {
            var query = new QueryFeatureName.Query();
            var result = sut.TestValidate(query);
            result.ShouldHaveValidationErrorFor(x => x.);
        }
        */
    }
}
