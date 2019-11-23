using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Superheroes.Interfaces;
using System;
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
            var superheroesRepository = scope.ServiceProvider.GetRequiredService<ISuperheroesRepository>();

            await superheroesRepository.LoadAsync();
        }

        public Task StopAsync(CancellationToken cancellationToken) => Task.CompletedTask;
    }
}
