using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;


namespace LowCodeProject.Verification
{
    public class CreateUpDateSchemeModelDto
    {
        /// <summary>
        /// 主键ID
        /// </summary>
        //public int SchemeId { get; set; }
        /// <summary>
        /// 流程标题
        /// </summary>
        [Required]
        public string SchemeTile { get; set; }
        /// <summary>
        /// 创建流程时间
        /// </summary>
        [Required]
        public DateTime CreateTime { get; set; } = DateTime.Now;
        /// <summary>
        /// 备注
        /// </summary>
        [Required]
        public string Remark { get; set; }
        /// <summary>
        /// 1完成 0 未完成 2撤销 
        /// </summary>
        [Required]
        public int SchemeStatus { get; set; }
        /// <summary>
        /// 申请人
        /// </summary>
        [Required]
        public string SchemsName { get; set; }
        /// <summary>
        /// 审核人
        /// </summary>
        [Required]
        public string Auditor { get; set; }
    }
}
