using LowCodeProject.DTO;
using LowCodeProject.Helper;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Services;

namespace LowCodeProject.IService.IServiceRBAC
{
    public interface IUserRoleService : IApplicationService
    {
        public Task<DataResult<int>> AddAsync(UserRoleModelDto roleModelDto);

        public Task<DataResult<UserRoleModelDto>> DeleteAsync(int id);

        public Task<DataResult<int>> UpdateAsync(UserRoleModelDto roleModelDto);

        public Task<DataPageReuslt<List<UserRoleModelDto>>> QueryAsync(int PageIndex, int PageSize);


        public string BaiDuYunToken();
        /// <summary>
        /// 人脸注册
        /// </summary>
        /// <param name="token"></param>
        /// <param name="base64"></param>
        /// <param name="tel"></param>
        /// <returns></returns>
        public  string  BaiDuYunAdd(string token, string base64, string tel);
    }
}
