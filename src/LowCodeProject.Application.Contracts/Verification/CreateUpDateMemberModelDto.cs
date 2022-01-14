using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;


namespace LowCodeProject.Verification
{
    public class CreateUpDateMemberModelDto
    {
        /// <summary>
        /// 会员Id
        /// </summary>
        // public int MemberId { get; set; }
        /// <summary>
        /// 用户Id
        /// </summary>
        [Required]
        public int UserId { get; set; }
        /// <summary>
        /// 开卡日期
        /// </summary>
        [Required]
        public DateTime OpenDate { get; set; } = DateTime.Now;
        /// <summary>
        /// 有效日期
        /// </summary>
        [Required]
        public DateTime ValidateDate { get; set; }
        /// <summary>
        ///   状态 0正常/1禁用
        /// </summary>
        [Required]
        public int CardStaus { get; set; }
        /// <summary>
        /// 会员图标
        /// </summary>
        [Required]
        public string MemberImg { get; set; }
    }
}
