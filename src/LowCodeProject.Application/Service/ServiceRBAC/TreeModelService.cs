using LowCodeProject.DTO;
using LowCodeProject.Helper;
using LowCodeProject.IService.IServiceRBAC;
using LowCodeProject.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace LowCodeProject.Service.ServiceRBAC
{
    public class TreeModelService : ApplicationService, ITreeService
    {

        private IRepository<TreeModel, int> repository;
        public TreeModelService(IRepository<TreeModel, int> _repository)
        {
            repository = _repository;
        }

        public async Task<DataResult<int>> AddAsync(MyTreeModelDto treeModelDto)
        {
            try
            {
                var data = ObjectMapper.Map<MyTreeModelDto, TreeModel>(treeModelDto);
                var list = await repository.InsertAsync(data);
                if(list!=null)
                {
                    return new DataResult<int>
                    {
                        Message = "添加成功",
                        TypeCode = HelperEnum.HttpCode.成功
                    };
                }
                return new DataResult<int>
                {
                    Message = "添加失败",
                    TypeCode = HelperEnum.HttpCode.未找到
                };
            }
            catch (Exception)
            {

                throw;
            }
        }

        /// <summary>
        /// 递归
        /// </summary>
        /// <param name="pid"></param>
        /// <returns></returns>
        public DataResult<List<TreeModelDto>> treeModelDtos(int pid = 0)  
        {
            try
            {
               var dtos = QueryTreeAsync(pid);
              return  new  DataResult<List<TreeModelDto>>
                {
                    Result = dtos,
                    Message = "显示成功!",
                    TypeCode = HelperEnum.HttpCode.成功
                };
            }
            catch (Exception)
            {
                throw;
            }
        }

        private    List<TreeModelDto>  QueryTreeAsync(int pid=0)
        {
            var Tree = repository.GetListAsync().Result.Where(x => x.TreeTid.Equals(pid)).ToList();

            Tree = Tree.Where(x => x.TreeTid.Equals(pid)).ToList();

            List<TreeModelDto> treeModel = new List<TreeModelDto>();
            Tree.ForEach( x=>{
                TreeModelDto treeModelDto = new TreeModelDto();
                treeModelDto.TreeName = x.TreeName;
                treeModelDto.Level= x.Level;
                treeModelDto.TreeDetail = x.TreeDetail;
                treeModelDto.Node_type = x.Node_type;
                treeModelDto.Link_url = x.Link_url;
                treeModelDto.Path = x.Path;
                treeModelDto.TreeName = x.TreeName;
                treeModelDto.list =  QueryTreeAsync(x.Id);
                treeModel.Add(treeModelDto);
            });
            return treeModel;
        }
    }
}
