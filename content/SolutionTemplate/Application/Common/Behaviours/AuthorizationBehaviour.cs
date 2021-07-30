using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace TopLevelDomain.ProjectName.Application.Common.Behaviours
{
    public class AuthorizationBehaviour<TRequest, TResponse> : IPipelineBehavior<TRequest, TResponse>
    {
        public async Task<TResponse> Handle(TRequest request, CancellationToken cancellationToken, RequestHandlerDelegate<TResponse> next)
        {
            // Not yet implemented

            return await next();
        }
    }
}
