using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace LowCodeProject.Verification
{
    public class CreateUpDateApplyTypeModelDto
    {
        ///// <summary>
        ///// id
        ///// </summary>
        //public int ApplyTypeId { get; set; } 
        /// <summary>
        /// 类型名称
        /// </summary>
        [Required]
        public string ApplyTypeName { get; set; }
        /// <summary>
        /// 类型图片
        /// </summary>
        [Required]
        public string ApplyTypeImg { get; set; }
        /// <summary>
        /// 创建时间
        /// </summary>
        [Required]
        public DateTime ApplyTypeCreateTime { get; set; }
    }
}
