using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;


namespace LowCodeProject.Verification
{
    public class CreateUpDateFormatModelDto
    {
        /// <summary>
        /// 格式id
        /// </summary>
        //public int FormatId { get; set; }
        /// <summary>
        /// 格式名称
        /// </summary>
        [Required]
        public string FormatName { get; set; }
        /// <summary>
        /// 格式详情
        /// </summary>
        [Required]
        public string FormatDetail { get; set; }
    }
}
