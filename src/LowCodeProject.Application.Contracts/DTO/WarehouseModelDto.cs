using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;

namespace LowCodeProject.DTO
{
    public class WarehouseModelDto : AuditedEntityDto<int>
    {
        /// <summary>
        /// 主键ID
        /// </summary>
        //  public int WarehouseId { get; set; }
        /// <summary>
        /// 创建时间
        /// </summary>
        public int CreateTime { get; set; }
        /// <summary>
        /// 应用id
        /// </summary>
        public int ApplyTypeId { get; set; }
        /// <summary>
        /// 应用类型名字
        /// </summary>
        public string ApplyTypeName { get; set; }
        /// <summary>
        /// 格式id
        /// </summary>
        public int FormatId { get; set; }
        /// <summary>
        /// 格式类型名称
        /// </summary>
        public string FormatName { get; set; }
        /// <summary>
        /// 0:运行中 1:暂停 2:异常
        /// </summary>
        public int WarehouseStatus { get; set; }
        /// <summary>
        /// 用户id
        /// </summary>
        public int Userid { get; set; }
        /// <summary>
        /// 用户名称
        /// </summary>
        public string UserName { get; set; }
    }
}
