using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace TopLevelDomain.ProjectName.WebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    [ApiVersion("1.0")]
    public class BaseApiController : ControllerBase
    {
        protected readonly ILogger logger;
        protected readonly ISender mediator;

        protected BaseApiController(ILogger logger, ISender mediator)
        {
            this.logger = logger;
            this.mediator = mediator;
        }
    }
}
