using LowCodeProject.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace LowCodeProject.Permissions
{
    public class LowCodeProjectPermissionDefinitionProvider : PermissionDefinitionProvider
    {
        public override void Define(IPermissionDefinitionContext context)
        {
            var myGroup = context.AddGroup(LowCodeProjectPermissions.GroupName);
            //Define your own permissions here. Example:
            //myGroup.AddPermission(LowCodeProjectPermissions.MyPermission1, L("Permission:MyPermission1"));
        }

        private static LocalizableString L(string name)
        {
            return LocalizableString.Create<LowCodeProjectResource>(name);
        }
    }
}
