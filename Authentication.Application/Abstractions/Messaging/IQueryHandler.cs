﻿using Authentication.Domain.Core.Primitives;
using MediatR;

namespace Authentication.Application.Abstractions.Messaging
{
    /// <summary>
    /// Represents the query interface.
    /// </summary>
    /// <typeparam name="TQuery">The query type.</typeparam>
    /// <typeparam name="TResponse">The query response type.</typeparam>
    public interface IQueryHandler<TQuery, TResponse> : IRequestHandler<TQuery, Result<TResponse>>
        where TQuery : IQuery<TResponse>
    {
    }
}