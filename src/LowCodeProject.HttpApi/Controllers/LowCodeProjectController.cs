using LowCodeProject.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace LowCodeProject.Controllers
{
    /* Inherit your controllers from this class.
     */
    public abstract class LowCodeProjectController : AbpControllerBase
    {
        protected LowCodeProjectController()
        {
            LocalizationResource = typeof(LowCodeProjectResource);
        }
    }
}