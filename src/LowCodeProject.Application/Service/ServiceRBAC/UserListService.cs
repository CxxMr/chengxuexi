using LowCodeProject.DTO;
using LowCodeProject.Helper;
using LowCodeProject.IService.IServiceRBAC;
using LowCodeProject.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace LowCodeProject.Service.ServiceRBAC
{
    public class UserListService : ApplicationService, IUserListService
    {

        /// <summary>
        /// 注入
        /// </summary>
        private IRepository<MyRoleModel, int>   RoleRepository;
        private IRepository<MyUserModel, int>     UserRepository;
        private IRepository<MyUserRoleModel, int> UserRoleRepository;
        private IRepository<MyPowerModel, int>   PowerRepository;
        private IRepository<MyRolePowerModel, int> RolePowerRepository;
        public UserListService(
            IRepository<MyRoleModel, int> _RoleRepository,
            IRepository<MyUserModel, int> _UserRepository,
            IRepository<MyUserRoleModel, int> _UserRoleRepository,
            IRepository<MyPowerModel, int> _PowerRepository,
            IRepository<MyRolePowerModel, int> _RolePowerRepository
            )
        {
            RoleRepository = _RoleRepository;
            UserRepository = _UserRepository;
            UserRoleRepository = _UserRoleRepository;
            PowerRepository = _PowerRepository;
            RolePowerRepository = _RolePowerRepository;
        }
        public  Task<DataResult<IEnumerable<ListUserDto>>> DataUserList(ListUserDto user)
        {
         
              throw new NotImplementedException();
        }

        public async Task<DataResult<IEnumerable<UserModelDto>>> DataUserLogin(UserModelDto userModelDto)
        {
            try
            {
                var list =await UserRepository.GetListAsync();

                var data = list.Where(x => x.UserAccount.Equals(userModelDto.UserAccount) && x.UserPwd.Equals(userModelDto.UserPwd)).ToList();
                if (data.Count()>0)
                {
                    return new DataResult<IEnumerable<UserModelDto>>
                    {
                        Message = "登录成功!",
                        TypeCode = HelperEnum.HttpCode.成功
                    };
                }
                return new DataResult<IEnumerable<UserModelDto>>
                {
                    Message = "账号或者密码错误",
                    TypeCode = HelperEnum.HttpCode.未找到
                };
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
