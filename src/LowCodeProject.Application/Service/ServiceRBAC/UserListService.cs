using LowCodeProject.DTO;
using LowCodeProject.Helper;
using LowCodeProject.Helper.EmailHelper;
using LowCodeProject.IService.IServiceRBAC;
using LowCodeProject.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
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

        /// <summary>
        /// 忘记密码+邮箱验证
        /// </summary>
        /// <param name="userModelDto"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        
        [HttpPost,Route("UpdatePassword")]
        public async Task<DataResult<List<UserModelDto>>> UpdatePassword(UserModelDto userModelDto)
        {
            Random rnd = new Random();
            try
            {
               //判断用户是否存在
                 var  lsit=await UserRepository.GetListAsync();
                lsit = lsit.Where(x => x.UserAccount.Equals(userModelDto.UserAccount)).ToList();
                //生成随机验证码
                int rep = 0;
                string str = string.Empty;
                long num2 = DateTime.Now.Ticks + rep;
                 rep++;
                Random random = new Random(((int)(((ulong)num2) & 0xffffffffL)) | ((int)(num2 >> rep)));
                for (int i = 0; i < 5; i++)
                {
                    char ch;
                    int num = random.Next();
                    if ((num % 2) == 0)
                    {
                        ch = (char)(0x30 + ((ushort)(num % 10)));
                    }
                    else
                    {
                        ch = (char)(0x41 + ((ushort)(num % 0x1a)));
                    }
                    str = str + ch.ToString();
                }

                //如果用户存在   则发送邮箱
                if (lsit.Count>=0)
                {
                    Mail mail = new Mail
                    {
                        //发送人
                        fromPerson = "2108878323@qq.com",
                        //找回密码的用户
                        recipientArry = new string[] { userModelDto.UserEmail },
                        mailCcArray = new string[] { "2108878323@qq.com" },
                        //标题
                        mailTitle = "找回密码",
                        mailBody = "您的验证码为:"+ str,
                        code = "tpyepanokjruehgi",
                        //设置默认的SMTP邮件服务器
                        host = "qq.com",
                        //html样式默认是否
                        isbodyHtml = false,
                        //文件默认为空
                        files = new List<IFormFile>()
                    };
                    ///发送邮箱
                    var list = LowCodeProject.Helper.EmailHelper.MailHelper.PostEmails(mail);
                    return new DataResult<List<UserModelDto>>
                    {
                        TypeCode = HelperEnum.HttpCode.成功,
                        Message = str
                    };
                }else
                {
                    return new DataResult<List<UserModelDto>>
                    {
                        TypeCode = HelperEnum.HttpCode.失败,
                        Message = "发送邮箱失败"
                    };
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
