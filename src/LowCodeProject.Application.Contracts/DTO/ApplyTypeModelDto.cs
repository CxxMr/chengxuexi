using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;

namespace LowCodeProject.DTO
{
    public class ApplyTypeModelDto:AuditedEntityDto<int>
    {
        ///// <summary>
        ///// id
        ///// </summary>
        //public int ApplyTypeId { get; set; } 
        /// <summary>
        /// 类型名称
        /// </summary>
        public string ApplyTypeName { get; set; }
        /// <summary>
        /// 类型图片
        /// </summary>
        public string ApplyTypeImg { get; set; }
        /// <summary>
        /// 创建时间
        /// </summary>
        public DateTime ApplyTypeCreateTime { get; set; }
    }
}
