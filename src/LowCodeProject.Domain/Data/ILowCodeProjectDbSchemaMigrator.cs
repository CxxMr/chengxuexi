using System.Threading.Tasks;

namespace LowCodeProject.Data
{
    public interface ILowCodeProjectDbSchemaMigrator
    {
        Task MigrateAsync();
    }
}
