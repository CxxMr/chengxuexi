using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;


namespace LowCodeProject.Verification
{
    public class CreateUpDateWarehouseModelDto
    {
        /// <summary>
        /// 主键ID
        /// </summary>
        //  public int WarehouseId { get; set; }
        /// <summary>
        /// 创建时间
        /// </summary>
        [Required]
        public int CreateTime { get; set; }
        /// <summary>
        /// 应用id
        /// </summary>
        [Required]
        public int ApplyTypeId { get; set; }
        /// <summary>
        /// 应用类型名字
        /// </summary>
        /// 
        [Required]
        public string ApplyTypeName { get; set; }
        /// <summary>
        /// 格式id
        /// </summary>
        /// 
        [Required]
        public int FormatId { get; set; }
        /// <summary>
        /// 格式类型名称
        /// </summary>
        ///    [Required]
        [Required]
        public string FormatName { get; set; }
        /// <summary>
        /// 0:运行中 1:暂停 2:异常
        /// </summary>
        /// 
        [Required]
        public int WarehouseStatus { get; set; }
        /// <summary>
        /// 用户id
        /// </summary>
        /// 
        [Required]
        public int Userid { get; set; }
        /// <summary>
        /// 用户名称
        /// </summary>
        /// 
        [Required]
        public string UserName { get; set; }
    }
}
