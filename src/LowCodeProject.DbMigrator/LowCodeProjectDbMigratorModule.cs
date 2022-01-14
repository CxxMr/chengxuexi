using LowCodeProject.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.BackgroundJobs;
using Volo.Abp.Modularity;

namespace LowCodeProject.DbMigrator
{
    [DependsOn(
        typeof(AbpAutofacModule),
        typeof(LowCodeProjectEntityFrameworkCoreModule),
        typeof(LowCodeProjectApplicationContractsModule)
        )]
    public class LowCodeProjectDbMigratorModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            Configure<AbpBackgroundJobOptions>(options => options.IsJobExecutionEnabled = false);
        }
    }
}
