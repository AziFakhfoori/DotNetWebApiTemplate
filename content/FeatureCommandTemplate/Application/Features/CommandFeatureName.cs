using FluentValidation;
using MediatR;
using Microsoft.Extensions.Logging;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace TopLevelDomain.ProjectName.Application.Features
{
    public class CommandFeatureName
    {
        public class Command : IRequest
        {
            
        }

        public class Validator : AbstractValidator<Command>
        {
            public Validator()
            {
                
            }
        }

        public class Handler : IRequestHandler<Command>
        {
            private readonly ILogger<Handler> logger;

            public Handler(ILogger<Handler> logger)
            {
                this.logger = logger;
            }

            public async Task<Unit> Handle(Command request, CancellationToken cancellationToken)
            {
                throw new NotImplementedException();
            }
        }
    }
}
