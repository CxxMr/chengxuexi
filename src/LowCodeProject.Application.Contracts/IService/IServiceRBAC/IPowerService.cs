using LowCodeProject.DTO;
using LowCodeProject.Helper;
using LowCodeProject.Verification;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;


namespace LowCodeProject.IService.IServiceRBAC
{
    public interface IPowerService : IApplicationService
    {

        public Task<DataResult<int>> AddAsync(PowerModelDto powerModelDto);

        public Task<DataResult<PowerModelDto>> DeleteAsync(int id);

        public Task<DataResult<int>> UpdateAsync(PowerModelDto powerModelDto);

        public Task<DataResult<List<PowerModelDto>>> QueryAsync(int PageIndex, int PageSize);
    }
}
