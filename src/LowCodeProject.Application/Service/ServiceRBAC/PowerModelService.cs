using LowCodeProject.DTO;
using LowCodeProject.Helper;
using LowCodeProject.IService;
using LowCodeProject.IService.IServiceRBAC;
using LowCodeProject.Model;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Entities;
using Volo.Abp.Domain.Repositories;

namespace LowCodeProject.Service.ServiceRBAC
{
    public class PowerModelService : ApplicationService, IPowerService
    {
        private IRepository<MyPowerModel, int> repository;
        public PowerModelService(IRepository<MyPowerModel, int> _repository)
        {
            repository = _repository; 
        }
        //添加
        #region
        [HttpPost, Route("PostAddPower")]
        public async Task<DataResult<int>> AddAsync(PowerModelDto roles)
        {
            try
            {
                var data = ObjectMapper.Map<PowerModelDto, MyPowerModel>(roles);
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
        [HttpPost, Route("DeletePower")]
        public async Task<DataResult<PowerModelDto>> DeleteAsync(int id)
        {
            try
            {
                var list = await repository.GetListAsync();
                var data = list.Where(x => x.Id.Equals(id)).FirstOrDefault();
                if (data != null)
                {
                    await repository.DeleteAsync(id);
                    return new DataResult<PowerModelDto>
                    {
                        Message = "删除成功",
                        TypeCode = HelperEnum.HttpCode.成功
                    };
                }
                return new DataResult<PowerModelDto>
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
        [HttpPost, Route("QueryPower")]
        public async Task<DataResult<List<PowerModelDto>>> QueryAsync(int PageIndex, int PageSize)
        {
            try
            {
                List<MyPowerModel> list = await repository.GetListAsync();
                var data = ObjectMapper.Map<List<MyPowerModel>, List<PowerModelDto>>(list);
                data = data.Skip((PageIndex - 1) * PageSize).Take(PageSize).ToList();
                return new DataResult<List<PowerModelDto>>
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

        /// <summary>
        /// 修改
        /// </summary>
        /// <param name="roleModelDto"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        /// 
        [HttpPost, Route("UpdatePower")]
        public async Task<DataResult<int>> UpdateAsync(PowerModelDto roleModelDto)
        {
            try
            {
                var data = ObjectMapper.Map<PowerModelDto, MyPowerModel>(roleModelDto);
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
    }
}
