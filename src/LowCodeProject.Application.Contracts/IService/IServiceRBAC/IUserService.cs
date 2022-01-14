using LowCodeProject.DTO;
using LowCodeProject.Verification;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace LowCodeProject.IService.IServiceRBAC
{
    public interface IUserService: ICrudAppService<UserModelDto,int, PagedAndSortedResultRequestDto,CreateUpDateUserModelDto>
    {


    }
}
