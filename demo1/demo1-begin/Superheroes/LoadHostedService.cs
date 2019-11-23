using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Superheroes.Interfaces;
using Superheroes.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Superheroes
{
    public class LoadHostedService : IHostedService
    {
        private readonly IServiceProvider _serviceProvider;
        public LoadHostedService(IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }

        public async Task StartAsync(CancellationToken cancellationToken)
        {
            // Create a new scope to retrieve scoped services
            using var scope = _serviceProvider.CreateScope();
            var superheroesService = scope.ServiceProvider.GetRequiredService<ISuperheroesRepository>();

            await superheroesService.LoadAsync();
        }

        public Task StopAsync(CancellationToken cancellationToken) => Task.CompletedTask;
    }
}
