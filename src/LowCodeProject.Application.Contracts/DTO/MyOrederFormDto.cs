using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;

namespace LowCodeProject.DTO
{
    public class MyOrederFormDto : AuditedEntityDto<int>
    {
        /// <summary>
        /// 订单编号
        /// </summary>
        // public int OrederId { get; set; }
        /// <summary>
        /// 订单名称
        /// </summary>
        public string OrederName { get; set; }
        /// <summary>
        /// 生成时间
        /// </summary>
        public DateTime OrederTime { get; set; } 
        /// <summary>
        /// 用户Id
        /// </summary>
        public int UserId { get; set; }
        /// <summary>
        /// 用户姓名
        /// </summary>
        public string UserName { get; set; }
        /// <summary>
        /// 1成功 -0失败
        /// </summary>
        public int OrederStatus { get; set; }

    }
}
