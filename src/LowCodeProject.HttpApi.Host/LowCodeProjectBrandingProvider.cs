using Volo.Abp.DependencyInjection;
using Volo.Abp.Ui.Branding;

namespace LowCodeProject
{
    [Dependency(ReplaceServices = true)]
    public class LowCodeProjectBrandingProvider : DefaultBrandingProvider
    {
        public override string AppName => "LowCodeProject";
    }
}
