﻿using System.Threading;
using System.Threading.Tasks;

namespace CodeBoss.CQRS.Queries
{
    public interface IQueryHandler<in TQuery, TResult> where TQuery : class, IQuery<TResult>
    {
        Task<TResult> HandleAsync(TQuery query, CancellationToken ct = default);
    }
}
