using LowCodeProject.DTO;
using LowCodeProject.Helper;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Services;

namespace LowCodeProject.IService.IServiceRBAC
{
    public interface IRolePowerService: IApplicationService
    {
        public Task<DataResult<int>> AddAsync(RolePowerModelDto roleModelDto);

        public Task<DataResult<RolePowerModelDto>> DeleteAsync(int id);

        public Task<DataResult<int>> UpdateAsync(RolePowerModelDto roleModelDto);

        public Task<DataResult<List<RolePowerModelDto>>> QueryAsync(int PageIndex, int PageSize);
    }
}
