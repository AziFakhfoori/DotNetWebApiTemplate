using FluentValidation;
using MediatR;
using Microsoft.Extensions.Logging;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace TopLevelDomain.ProjectName.Application.Features
{
    public class QueryFeatureName
    {
        public class Query : IRequest
        {
            
        }

        public class Validator : AbstractValidator<Query>
        {
            public Validator()
            {
                
            }
        }

        public class Handler : IRequestHandler<Query>
        {
            private readonly ILogger<Handler> logger;

            public Handler(ILogger<Handler> logger)
            {
                this.logger = logger;
            }

            public async Task<Unit> Handle(Query request, CancellationToken cancellationToken)
            {
                throw new NotImplementedException();
            }
        }
    }
}
