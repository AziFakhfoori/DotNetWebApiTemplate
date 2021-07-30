using TopLevelDomain.ProjectName.Application.Common.Interfaces;
using System;

namespace TopLevelDomain.ProjectName.Infrastructure.Services
{
    public class DateTimeService : IDateTime
    {
        public DateTime Now => DateTime.Now;

        public DateTime UtcNow => DateTime.UtcNow;
    }
}
