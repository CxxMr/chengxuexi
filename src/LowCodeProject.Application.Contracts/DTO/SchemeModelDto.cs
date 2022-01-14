using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;

namespace LowCodeProject.DTO
{
    public class SchemeModelDto : AuditedEntityDto<int>
    {
        /// <summary>
        /// 主键ID
        /// </summary>
        //public int SchemeId { get; set; }
        /// <summary>
        /// 流程标题
        /// </summary>
        public string SchemeTile { get; set; }
        /// <summary>
        /// 创建流程时间
        /// </summary>
        public DateTime CreateTime { get; set; }
        /// <summary>
        /// 备注
        /// </summary>
        public string Remark { get; set; }
        /// <summary>
        /// 1完成 0 未完成 2撤销 
        /// </summary>
        public int SchemeStatus { get; set; }
        /// <summary>
        /// 申请人
        /// </summary>
        public string SchemsName { get; set; }
        /// <summary>
        /// 审核人
        /// </summary>
        public string Auditor { get; set; }
    }
}
