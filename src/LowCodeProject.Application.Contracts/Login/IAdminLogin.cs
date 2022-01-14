using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Services;

namespace LowCodeProject.Login
{
    public interface IAdminLogin:IApplicationService
    {
        public Task<TokenDto> GetLogin(string LoginName, string Loginpwd);//IDS4
        public Task<TokenDto> UserLogin(string LoginName, string Loginpwd);//用户登录IDS4
        public Task<TokenDto> JWTUserLogin(string LoginName, string Loginpwd);//JWT
    }
}
