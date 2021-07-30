using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TopLevelDomain.ProjectName.WebApi.Controllers
{
    public class ControllerNameController : BaseApiController
    {
        public ControllerNameController(
            ILogger<ControllerNameController> logger, 
            ISender mediator
        ) : base(logger, mediator)
        {
            
        }
    }
}