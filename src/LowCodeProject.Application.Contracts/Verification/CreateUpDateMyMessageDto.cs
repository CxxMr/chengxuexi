using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;


namespace LowCodeProject.Verification
{
    public class CreateUpDateMyMessageDto
    {
        /// <summary>
        /// 消息主键
        /// </summary>
        // public int MessageId { get; set; }
        /// <summary>
        /// 分类
        /// </summary>
        [Required]
        public string MessageTypeName { get; set; }
        /// <summary>
        /// 消息源头
        /// </summary>
        [Required]
        public int FromId { get; set; }
        /// <summary>
        /// 到达源头
        /// </summary>
        [Required]
        public int ToId { get; set; }
        /// <summary>
        /// 消息源头名称
        /// </summary>
        [Required]
        public string FromName { get; set; }
        /// <summary>
        /// 消息到达名称
        /// 
        /// </summary>
        [Required]
        public string ToName { get; set; }
        /// <summary>
        /// -1:已删除;0默认
        /// </summary>
        [Required]
        public int FromStatus { get; set; }
        /// <summary>
        /// -1:已删除;-0默认未读;-2已读
        /// </summary>
        [Required]
        public int ToStatus { get; set; }
        /// <summary>
        /// 点击消息跳转的页面
        /// </summary>
        [Required]
        public string Href { get; set; }
        /// <summary>
        /// 消息标题
        /// </summary>
        [Required]
        public string Tile { get; set; }
        /// <summary>
        /// 消息内容
        /// </summary>
        [Required]
        public string Content { get; set; }
        /// <summary>
        /// 创建时间
        /// </summary>
        [Required]
        public DateTime CreateTime { get; set; } = DateTime.Now;
        /// <summary>
        /// 创建消息人Id
        /// </summary>
        [Required]
        public int CreatId { get; set; }
    }
}
