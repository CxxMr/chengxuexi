using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;


namespace LowCodeProject.Verification
{
    public class CreateUpDateJournalModelDto
    {

        /// <summary>
        /// 日志Id
        /// </summary>
        ///public int JournalId { get; set; }
        /// <summary>
        /// 日志内容
        /// </summary>
        [Required]
        public string Content { get; set; }
        /// <summary>
        /// 应用分类名称
        /// </summary>
        [Required]
        public string FormatName { get; set; }
        /// <summary>
        /// 格式分类ID
        /// </summary>
        [Required]
        public int FormatId { get; set; }
        /// <summary>
        /// 操作所属模块
        /// </summary>
        [Required]
        public string Href { get; set; }
        /// <summary>
        /// 记录当前时间
        /// </summary>
        [Required]
        public DateTime CreateTime { get; set; }
        /// <summary>
        /// 操作人Id
        /// </summary>
        [Required]
        public int CreateId { get; set; }
        /// <summary>
        /// 操作人
        /// </summary>
        [Required]
        public string CreateName { get; set; }
        /// <summary>
        /// 操作机器的Ip地址
        /// </summary>
        [Required]
        public string Ip { get; set; }
        /// <summary>
        /// 0:成功/1:失败 状态
        /// </summary>
        /// 
        public int Result { get; set; }
        /// <summary>
        /// 所属应用
        /// </summary>
        [Required]
        public string Application { get; set; }
    }
}
