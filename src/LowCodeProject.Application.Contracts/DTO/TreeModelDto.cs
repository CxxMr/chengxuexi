using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;

namespace LowCodeProject.DTO
{
    public class TreeModelDto : AuditedEntityDto<int>
    {
        /// <summary>
        /// 递归树的主键Id
        /// </summary>
      //  public int TreeId { get; set; }
        /// <summary>
        ///  递归名称
        /// </summary>
        public string TreeName { get; set; }
        /// <summary>
        /// 递归父级Id
        /// </summary>
        public int TreeTid { get; set; }
        /// <summary>
        /// 详情信息
        /// </summary>
        public string TreeDetail { get; set; }
        /// <summary>
        /// 节点类型, 文件夹/页面/按钮
        /// </summary>
        public string Node_type { get; set; }
        /// <summary>
        /// 页面对应的地址文件夹/按钮
        /// </summary>
        public string Link_url { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string Level { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string Path { get; set; }


    }
}
