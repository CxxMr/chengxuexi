using LowCodeProject.DTO;
using LowCodeProject.IService.IServiceRBAC;
using LowCodeProject.Model;
using LowCodeProject.Verification;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace LowCodeProject.Service.ServiceRBAC
{
    public class UserModelService:CrudAppService<MyUserModel,UserModelDto,int, PagedAndSortedResultRequestDto, CreateUpDateUserModelDto>, IUserService
    {
        private readonly IRepository<MyUserModel, int> userModels;

        public UserModelService(IRepository<MyUserModel, int> _userModels) :base(_userModels)
        {
            userModels = _userModels;
        }


    }
}
