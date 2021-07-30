using MediatR;
using Microsoft.Extensions.Logging;
using System.Diagnostics;
using System.Threading;
using System.Threading.Tasks;

namespace TopLevelDomain.ProjectName.Application.Common.Behaviours
{
    public class PerformanceBehaviour<TRequest, TResponse> : IPipelineBehavior<TRequest, TResponse>
    {
        private readonly Stopwatch _timer;
        private readonly ILogger<TRequest> _logger;

        public PerformanceBehaviour(ILogger<TRequest> logger)
        {
            _timer = new Stopwatch();
            _logger = logger;
        }

        public async Task<TResponse> Handle(TRequest request, CancellationToken cancellationToken, RequestHandlerDelegate<TResponse> next)
        {
            _timer.Start();

            var response = await next();

            _timer.Stop();

            var elapsedMilliseconds = _timer.ElapsedMilliseconds;

            var requestName = typeof(TRequest).Name;

            if (elapsedMilliseconds > 500)
            {
                _logger.LogWarning("TopLevelDomain.ProjectName Long Running Request: Name:{Name} (Elapsed:{ElapsedMilliseconds} milliseconds) {@Request}",
                    requestName,
                    elapsedMilliseconds,
                    request
                    );
            }

            return response;
        }
    }
}
