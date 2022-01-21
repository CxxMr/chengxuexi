using LowCodeProject.DTO;
using LowCodeProject.Helper;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Services;

namespace LowCodeProject.IService.IServiceRBAC
{
    public interface IUserListService : IApplicationService
    {
           //联查显示
         public Task<DataResult<IEnumerable<ListUserDto>>>  DataUserList(ListUserDto user);

        //登录系统
        public Task<DataResult<IEnumerable<UserModelDto>>> DataUserLogin(UserModelDto userModelDto);

        /// <summary>
        /// 忘记密码+邮箱验证
        /// </summary>
        /// <returns></returns>
        public Task<DataResult<List<UserModelDto>>> UpdatePassword(UserModelDto userModelDto);

    }
}
