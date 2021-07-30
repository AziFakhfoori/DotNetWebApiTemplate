using System.Threading;
using System.Threading.Tasks;

namespace TopLevelDomain.ProjectName.Application.Common.Interfaces
{
    public interface IApplicationDbContext
    {
        //TODO Define DbSets
        //public DbSet<Domain.Entities.EntityName> EntityName { get; set; }

        Task<int> SaveChangesAsync(CancellationToken cancellationToken = new CancellationToken());
    }
}
