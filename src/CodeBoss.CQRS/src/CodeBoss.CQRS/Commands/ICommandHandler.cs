﻿using System.Threading;
using System.Threading.Tasks;

namespace CodeBoss.CQRS.Commands
{
    public interface ICommandHandler<in TCommand> where TCommand : class, ICommand
    {
        Task HandleAsync(TCommand command, CancellationToken cancellationToken = default);
    }
}
