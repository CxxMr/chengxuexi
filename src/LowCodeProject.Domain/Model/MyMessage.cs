using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Entities;
namespace LowCodeProject.Model
{
    /// <summary>
    /// 消息
    /// </summary>
    public class MyMessage : AggregateRoot<int>
    {
        /// <summary>
        /// 消息主键
        /// </summary>
       // public int MessageId { get; set; }
        /// <summary>
        /// 分类
        /// </summary>
        public string MessageTypeName { get; set; }
        /// <summary>
        /// 消息源头
        /// </summary>
        public int FromId { get; set; }
        /// <summary>
        /// 到达源头
        /// </summary>
        public int ToId { get; set; }
        /// <summary>
        /// 消息源头名称
        /// </summary>
        public string FromName { get; set; }
        /// <summary>
        /// 消息到达名称
        /// </summary>
        public string ToName { get; set; }
        /// <summary>
        /// -1:已删除;0默认
        /// </summary>
        public int FromStatus { get; set; }
        /// <summary>
        /// -1:已删除;-0默认未读;-2已读
        /// </summary>
        public int ToStatus { get; set; }
        /// <summary>
        /// 点击消息跳转的页面
        /// </summary>
        public string Href { get; set; }
        /// <summary>
        /// 消息标题
        /// </summary>
        public string Tile { get; set; }
        /// <summary>
        /// 消息内容
        /// </summary>
        public string Content { get; set; }
        /// <summary>
        /// 创建时间
        /// </summary>
        public DateTime CreateTime { get; set; }=DateTime.Now;
        /// <summary>
        /// 创建消息人Id
        /// </summary>
        public int CreatId { get; set; }

    }
}
