using Authentication.Domain.Interfaces.Repository;
using Authentication.Infrastructure.Database;

namespace Authentication.Infrastructure.Repository
{
    public class UnitOfWork: IUnitOfWork
    {
        private readonly ApplicationDbContext _context;


        public UnitOfWork(ApplicationDbContext context)
        {
            _context = context;
        }

        public Task SaveChangesAsync(CancellationToken cancellationToken = default)
        {
            return _context.SaveChangesAsync(cancellationToken);
        }
    }
}
