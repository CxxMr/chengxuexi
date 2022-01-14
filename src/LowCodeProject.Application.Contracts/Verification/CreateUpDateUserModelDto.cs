using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;


namespace LowCodeProject.Verification
{
    public class CreateUpDateUserModelDto
    {
        /// <summary>
        /// 用户id
        /// </summary>
        //  public int UserId { get; set; }
        /// <summary>
        /// 用户姓名
        /// </summary>
        [Required]
        public string UserName { get; set; }
        /// <summary>
        /// 用户账号
        /// </summary>
        [Required]
        public string UserAccount { get; set; }
        /// <summary>
        /// 用户密码
        /// </summary>
        [Required]
        public string UserPwd { get; set; }
        /// <summary>
        /// 用户手机号
        /// </summary>
        [Required]
        public string UserPhone { get; set; }
        /// <summary>
        /// 用户邮箱地址
        /// </summary>
        [Required]
        public string UserEmail { get; set; }
        /// <summary>
        /// 0:男 1:女  2:私密
        /// </summary>
        [Required]
        public int Sex { get; set; }
        /// <summary>
        /// 0:正常 1:异常 2:注销
        /// </summary>
        [Required]
        public int Status { get; set; }
        /// <summary>
        /// 经办时间
        /// </summary>
        [Required]
        public DateTime CreateTime { get; set; }
        /// <summary>
        /// 简介
        /// </summary>
        [Required]
        public string Detail { get; set; }
    }
}
