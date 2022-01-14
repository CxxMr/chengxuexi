using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using LowCodeProject.Data;
using Volo.Abp.DependencyInjection;

namespace LowCodeProject.EntityFrameworkCore
{
    public class EntityFrameworkCoreLowCodeProjectDbSchemaMigrator
        : ILowCodeProjectDbSchemaMigrator, ITransientDependency
    {
        private readonly IServiceProvider _serviceProvider;

        public EntityFrameworkCoreLowCodeProjectDbSchemaMigrator(
            IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }

        public async Task MigrateAsync()
        {
            /* We intentionally resolving the LowCodeProjectDbContext
             * from IServiceProvider (instead of directly injecting it)
             * to properly get the connection string of the current tenant in the
             * current scope.
             */

            await _serviceProvider
                .GetRequiredService<LowCodeProjectDbContext>()
                .Database
                .MigrateAsync();
        }
    }
}
