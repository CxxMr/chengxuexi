using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace LowCodeProject.Data
{
    /* This is used if database provider does't define
     * ILowCodeProjectDbSchemaMigrator implementation.
     */
    public class NullLowCodeProjectDbSchemaMigrator : ILowCodeProjectDbSchemaMigrator, ITransientDependency
    {
        public Task MigrateAsync()
        {
            return Task.CompletedTask;
        }
    }
}