using Volo.Abp.Settings;

namespace LowCodeProject.Settings
{
    public class LowCodeProjectSettingDefinitionProvider : SettingDefinitionProvider
    {
        public override void Define(ISettingDefinitionContext context)
        {
            //Define your own settings here. Example:
            //context.Add(new SettingDefinition(LowCodeProjectSettings.MySetting1));
        }
    }
}
