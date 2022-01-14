using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;

namespace LowCodeProject.DTO
{
    public class MemberModelDto : AuditedEntityDto<int>
    {
        /// <summary>
        /// 会员Id
        /// </summary>
       // public int MemberId { get; set; }
        /// <summary>
        /// 用户Id
        /// </summary>
        public int UserId { get; set; }
        /// <summary>
        /// 开卡日期
        /// </summary>
        public DateTime OpenDate { get; set; } 
        /// <summary>
        /// 有效日期
        /// </summary>
        public DateTime ValidateDate { get; set; }
        /// <summary>
        ///   状态 0正常/1禁用
        /// </summary>
        public int CardStaus { get; set; }
        /// <summary>
        /// 会员图标
        /// </summary>
        public string MemberImg { get; set; }
    }
}
