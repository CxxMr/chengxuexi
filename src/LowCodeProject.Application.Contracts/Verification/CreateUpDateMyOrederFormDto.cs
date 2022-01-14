using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;


namespace LowCodeProject.Verification
{
    public class CreateUpDateMyOrederFormDto
    {
        /// <summary>
        /// 订单编号
        /// </summary>
        // public int OrederId { get; set; }
        /// <summary>
        /// 订单名称
        /// </summary>
        [Required]
        public string OrederName { get; set; }
        /// <summary>
        /// 生成时间
        /// </summary>
        [Required]
        public DateTime OrederTime { get; set; } = DateTime.Now;
        /// <summary>
        /// 用户Id
        /// </summary>
        [Required]
        public int UserId { get; set; }
        /// <summary>
        /// 用户姓名
        /// </summary>
        [Required]
        public string UserName { get; set; }
        /// <summary>
        /// 1成功 -0失败
        /// </summary>
        [Required]
        public int OrederStatus { get; set; }
    }
}
