using AutoMapper;
using LowCodeProject.DTO;
using LowCodeProject.Model;
using LowCodeProject.Verification;

namespace LowCodeProject
{
    public class LowCodeProjectApplicationAutoMapperProfile : Profile
    {
        public LowCodeProjectApplicationAutoMapperProfile()
        {
            /* You can configure your AutoMapper mapping configuration here.
             * Alternatively, you can split your mapping configurations
             * into multiple profile classes for a better organization. */

            //用户映射CRUD
            CreateMap<MyUserModel, UserModelDto>();
            CreateMap<CreateUpDateUserModelDto, MyUserModel>();
            //////
            //CreateMap<MyRoleModel, RoleModelDto>();
            //CreateMap<CreateUpDateRoleModelDto, MyRoleModel>();
            //角色映射
            CreateMap<RoleModelDto, MyRoleModel>();
            CreateMap<MyRoleModel, RoleModelDto>();
            CreateMap<CreateUpDateRoleModelDto, MyRoleModel>();
            //用户角色映射
            CreateMap<UserRoleModelDto, MyUserRoleModel>();
            CreateMap<MyUserRoleModel, UserRoleModelDto>();
            CreateMap<CreateUpdateUserRoleModelDto, MyUserRoleModel>();
            //角色权限映射
            CreateMap<RolePowerModelDto, MyRolePowerModel>();
            CreateMap<MyRolePowerModel, RolePowerModelDto>();
            CreateMap<CreateUpDateRolePowerModelDto, MyRolePowerModel>();
            //权限映射
            CreateMap<PowerModelDto, MyPowerModel>();
            CreateMap<MyPowerModel, PowerModelDto>();
            CreateMap<CreateUpDatePowerModelDto, MyPowerModel>();






            //CreateMap<MyRoleModel, RoleModelDto>();
            //CreateMap<CreateUpDateRoleModelDto, MyRoleModel>();

            //CreateMap<MyRoleModel, RoleModelDto>();
            //CreateMap<CreateUpDateRoleModelDto, MyRoleModel>();

            //CreateMap<MyRoleModel, RoleModelDto>();
            //CreateMap<CreateUpDateRoleModelDto, MyRoleModel>();

            //CreateMap<MyRoleModel, RoleModelDto>();
            //CreateMap<CreateUpDateRoleModelDto, MyRoleModel>();

            //CreateMap<MyRoleModel, RoleModelDto>();
            //CreateMap<CreateUpDateRoleModelDto, MyRoleModel>();

            //CreateMap<MyRoleModel, RoleModelDto>();
            //CreateMap<CreateUpDateRoleModelDto, MyRoleModel>();




        }
    }
}
