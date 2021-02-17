﻿using System.Threading;
using System.Threading.Tasks;
using Microsoft.Extensions.Hosting;

namespace CodeBoss.AspNetCore.Startup
{
    public class StartupHostedService : IHostedService
    {
        private readonly IStartupInitializer _startupInitializer;

        public StartupHostedService(IStartupInitializer startupInitializer) => _startupInitializer = startupInitializer;

        public Task StartAsync(CancellationToken cancellationToken) => _startupInitializer?.InitializeAsync() ?? Task.CompletedTask;
        public Task StopAsync(CancellationToken cancellationToken) => Task.CompletedTask;
    }
}
