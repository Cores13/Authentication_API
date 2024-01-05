namespace Authentication.Domain.Interfaces.Repository
{
    public interface IUnitOfWork
    {
        Task SaveChangesAsync(CancellationToken cancellationToken);
    }
}
