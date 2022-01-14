using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;


namespace LowCodeProject.Verification
{
    public class CreateUpDatePowerModelDto
    {
        /// <summary>
        /// 权限id
        /// </summary>
        //  public int PowerId { get; set; }
        /// <summary>
        /// 权限名称
        /// </summary>
        [Required]
        public string PowerName { get; set; }
    }
}
