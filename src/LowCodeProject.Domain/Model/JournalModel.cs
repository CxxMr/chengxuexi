using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Entities;
namespace LowCodeProject.Model
{
    /// <summary>
    /// 日志
    /// </summary>
    public class JournalModel : AggregateRoot<int>
    {
        /// <summary>
        /// 日志Id
        /// </summary>
        ///public int JournalId { get; set; }
        /// <summary>
        /// 日志内容
        /// </summary>
        public string Content { get; set; }
        /// <summary>
        /// 应用分类名称
        /// </summary>
        public string FormatName { get; set; }
        /// <summary>
        /// 格式分类ID
        /// </summary>
        public int FormatId { get; set; }
        /// <summary>
        /// 操作所属模块
        /// </summary>
        public string Href { get; set; }
        /// <summary>
        /// 记录当前时间
        /// </summary>
        public DateTime CreateTime { get; set; }=DateTime.Now;
        /// <summary>
        /// 操作人Id
        /// </summary>
        public int CreateId { get; set; }
        /// <summary>
        /// 操作人
        /// </summary>
        public string CreateName { get; set; }
        /// <summary>
        /// 操作机器的Ip地址
        /// </summary>
        public string Ip { get; set; }
        /// <summary>
        /// 0:成功/1:失败 状态
        /// </summary>
        public int Result { get; set; }
        /// <summary>
        /// 所属应用
        /// </summary>
        public string Application { get; set; }
    }
}
