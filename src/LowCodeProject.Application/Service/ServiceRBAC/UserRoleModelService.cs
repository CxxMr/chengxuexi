using AutoMapper;
using LowCodeProject.DTO;
using LowCodeProject.Helper;
using LowCodeProject.Helper.EmailHelper;
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
using Volo.Abp.ObjectMapping;

namespace LowCodeProject.Service.ServiceRBAC
{
    public class UserRoleModelService : ApplicationService, IUserRoleService
    {

        private IRepository<MyUserRoleModel, int> repository;
        public UserRoleModelService(IRepository<MyUserRoleModel, int> _repository)
        {
            repository = _repository;
        }

        public async Task<DataResult<int>> AddAsync(UserRoleModelDto roleModelDto)
        {
            try
            {
                var data = ObjectMapper.Map<UserRoleModelDto, MyUserRoleModel>(roleModelDto);
                await repository.InsertAsync(data);
                return new DataResult<int>
                {
                    Message = "成功",
                    TypeCode = HelperEnum.HttpCode.成功
                };
            }
            catch (Exception)
            {
                return new DataResult<int>
                {
                    Message = "添加失败",
                    TypeCode = HelperEnum.HttpCode.服务器内部错误

                };
            }
        }
        public async Task<DataResult<UserRoleModelDto>> DeleteAsync(int id)
        {
            try
            {
                var list = await repository.GetListAsync();
                var data = list.Where(x => x.Id.Equals(id)).FirstOrDefault();
                if (data != null)
                {
                    await repository.DeleteAsync(id);
                    return new DataResult<UserRoleModelDto>
                    {
                        Message = "删除成功",
                        TypeCode = HelperEnum.HttpCode.成功
                    };
                }
                return new DataResult<UserRoleModelDto>
                {
                    Message = "删除失败",
                    TypeCode = HelperEnum.HttpCode.服务器内部错误
                };
            }
            catch (Exception)
            {
                throw;
            }
        }

        public async Task<DataResult<List<UserRoleModelDto>>> QueryAsync(int PageIndex, int PageSize)
        {
            try
            {
                List<MyUserRoleModel> list = await repository.GetListAsync();
                var data = ObjectMapper.Map<List<MyUserRoleModel>, List<UserRoleModelDto>>(list);
                data = data.Skip((PageIndex - 1) * PageSize).Take(PageSize).ToList();
                return new DataResult<List<UserRoleModelDto>>
                {
                    Result = data,
                    Message = "显示",
                    TypeCode = HelperEnum.HttpCode.成功
                };
            }
            catch (Exception)
            {
                throw;
            }
        }

        public Task<DataResult<int>> UpdateAsync(UserRoleModelDto roleModelDto)
        {
            throw new NotImplementedException();
        }
    }
}

