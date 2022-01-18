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
    public class RoleModelService : ApplicationService, IRoleService
    {
        //   : CrudAppService<MyRoleModel, RoleModelDto, int, PagedAndSortedResultRequestDto, CreateUpDateRoleModelDto>,
        private IRepository<MyRoleModel, int> repository;
        public RoleModelService(IRepository<MyRoleModel, int> _repository) 
        {
            repository = _repository;
        }
        //添加
        #region
        [HttpPost, Route("PostRoleModel")]
        public async Task<DataResult<int>> AddAsync(RoleModelDto roles)
        {
            try
            {
                var data = ObjectMapper.Map<RoleModelDto, MyRoleModel>(roles);
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

        #endregion
        /// <summary>
        /// 删除
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        #region
        public async Task<DataResult<RoleModelDto>> DeleteAsync(int id)
        {
            try
            {
                var list = await repository.GetListAsync();
                var data = list.Where(x => x.Id.Equals(id)).FirstOrDefault();
                if (data != null)
                {
                    await repository.DeleteAsync(id);
                    return new DataResult<RoleModelDto>
                    {
                        Message = "删除成功",
                        TypeCode = HelperEnum.HttpCode.成功
                    };
                }
                return new DataResult<RoleModelDto>
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

        #endregion
        /// <summary>
        /// 显示+分页
        /// </summary>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public async Task<DataResult<List<RoleModelDto>>>  QueryAsync(int PageIndex,int PageSize)
        {
            try
            {
                List<MyRoleModel> list = await repository.GetListAsync();
                var total=list.Count();
                var data = ObjectMapper.Map<List<MyRoleModel>, List<RoleModelDto>>(list);
                data=data.Skip((PageIndex-1)*PageSize).Take(PageSize).ToList();
                return new DataResult<List<RoleModelDto>>
                {
                    Result=data,
                    Message = "显示",
                    TypeCode = HelperEnum.HttpCode.成功
                };
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// 修改
        /// </summary>
        /// <param name="roleModelDto"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public async Task<DataResult<int>> UpdateAsync(RoleModelDto roleModelDto)
        {
            try
            {
                var data = ObjectMapper.Map<RoleModelDto, MyRoleModel>(roleModelDto);
                var Count = await repository.UpdateAsync(data);
                if (Count != null)
                {
                    return new DataResult<int>
                    {
                        Message = "修改成功",
                        TypeCode = HelperEnum.HttpCode.成功
                    };
                }
                else
                {
                    return new DataResult<int>
                    {
                        Message = "修改失败",
                        TypeCode = HelperEnum.HttpCode.服务器内部错误
                    };
                }
              
            }
            catch (Exception)
            {

                throw;
            }
        }

        /// <summary>
        /// 发送邮箱
        /// </summary>
        /// <param name="mails"></param>
        /// <returns></returns>
        [HttpPost, Route("Email")]
        public int Email([FromForm] Mail mails)
        {
            var list = LowCodeProject.Helper.EmailHelper.MailHelper.PostEmails(mails);
            return 1;
        }

        
    }
}

 
    










