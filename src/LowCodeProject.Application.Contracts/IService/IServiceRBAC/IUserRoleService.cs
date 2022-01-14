using LowCodeProject.DTO;
using LowCodeProject.Helper;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace LowCodeProject.IService.IServiceRBAC
{
    public interface IUserRoleService
    {
        public Task<DataResult<int>> AddAsync(UserRoleModelDto roleModelDto);

        public Task<DataResult<UserRoleModelDto>> DeleteAsync(int id);

        public Task<DataResult<int>> UpdateAsync(UserRoleModelDto roleModelDto);

        public Task<DataResult<List<UserRoleModelDto>>> QueryAsync(int PageIndex, int PageSize);
    }
}
