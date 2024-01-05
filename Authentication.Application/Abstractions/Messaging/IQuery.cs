﻿using Authentication.Domain.Core.Primitives;
using MediatR;

namespace Authentication.Application.Abstractions.Messaging
{
    /// <summary>
    /// Represents the query interface.
    /// </summary>
    /// <typeparam name="TResponse">The query response type.</typeparam>
    public interface IQuery<TResponse> : IRequest<Result<TResponse>>
    {
    }
}