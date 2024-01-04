﻿namespace Digimash.Domain.Interfaces.Repository
{
    public interface IUnitOfWork
    {
        Task SaveChangesAsync(CancellationToken cancellationToken);
    }
}
