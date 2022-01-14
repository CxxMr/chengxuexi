using System;
using System.Collections.Generic;
using System.Text;
using LowCodeProject.Localization;
using Volo.Abp.Application.Services;

namespace LowCodeProject
{
    /* Inherit your application services from this class.
     */
    public abstract class LowCodeProjectAppService : ApplicationService
    {
        protected LowCodeProjectAppService()
        {
            LocalizationResource = typeof(LowCodeProjectResource);
        }
    }
}
