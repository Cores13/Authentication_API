﻿using System.Linq.Expressions;

namespace Authentication.Domain.Interfaces.Repository
{
    public interface IRepository<T> where T : class
    {
        Task<List<T>> GetAll(Expression<Func<T, bool>>? filter = null, string? includeProperties = null);
        T Get(Expression<Func<T, bool>>? filter, string? includeProperties = null);
        bool Any(Expression<Func<T, bool>> filter);
        void Add(T entity);
        void Remove(T entity);
        void GetAddedEntity(T entity);
    }
}
