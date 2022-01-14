using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;

namespace LowCodeProject.DTO
{
    public class FormatModelDto : AuditedEntityDto<int>
    {
        /// <summary>
        /// 格式id
        /// </summary>
        //public int FormatId { get; set; }
        /// <summary>
        /// 格式名称
        /// </summary>
        public string FormatName { get; set; }
        /// <summary>
        /// 格式详情
        /// </summary>
        public string FormatDetail { get; set; }

    }
}
