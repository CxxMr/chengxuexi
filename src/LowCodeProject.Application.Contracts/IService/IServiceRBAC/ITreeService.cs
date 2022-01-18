using LowCodeProject.DTO;
using LowCodeProject.Helper;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Services;

namespace LowCodeProject.IService.IServiceRBAC
{
    public interface ITreeService : IApplicationService
    {
        //递归
        public DataResult<List<TreeModelDto>> treeModelDtos(int pid = 0);
        /// <summary>
        /// 权限树添加
        /// </summary>
        /// <param name="roleModelDto"></param>
        /// <returns></returns>
        public Task<DataResult<int>> AddAsync(MyTreeModelDto treeModelDto);
    }
}
