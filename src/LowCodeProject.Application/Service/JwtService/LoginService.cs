using AutoMapper.Configuration;
using LowCodeProject.Login;
using LowCodeProject.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace LowCodeProject.Service.JwtService
{
    public class LoginService : ApplicationService, IAdminLogin
    {
        private readonly IRepository<MyUserModel, int> _repository;
        private IConfiguration _configuration;
        public LoginService(IRepository<MyUserModel, int> repository, IConfiguration configuration)
        {
            _repository = repository;
            _configuration = configuration;
        }
        public Task<TokenDto> GetLogin(string LoginName, string Loginpwd)
        {
            throw new NotImplementedException();
        }

        public async Task<TokenDto> JWTUserLogin(string LoginName, string Loginpwd)
        {
            var list = await _repository.GetListAsync();
            var slist = list.Where(x => x.UserAccount == LoginName && x.UserPwd == Loginpwd).FirstOrDefault();
            if (slist != null)
            {
                return new TokenDto
                {
                    Msg = "成功",
                    state = true,
                    token = JWT.JWToken.CreateToken(LoginName)
                };
            }
            else
            {
                return new TokenDto { Msg = "失败", state = false };
            }
        }

        public Task<TokenDto> UserLogin(string LoginName, string Loginpwd)
        {
            throw new NotImplementedException();
        }
    }
}
