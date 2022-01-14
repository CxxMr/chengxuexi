using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Entities;
namespace LowCodeProject.Model
{
    /// <summary>
    /// 流程
    /// </summary>
    public class SchemeModel : AggregateRoot<int>
    {
        /// <summary>
        /// 主键ID
        /// </summary>
        //public int SchemeId { get; set; }
        /// <summary>
        /// 流程标题
        /// </summary>
        public string SchemeTile { get; set; }
        /// <summary>
        /// 创建流程时间
        /// </summary>
        public DateTime CreateTime { get; set; }=DateTime.Now;
        /// <summary>
        /// 备注
        /// </summary>
        public string Remark { get; set; }
        /// <summary>
        /// 1完成 0 未完成 2撤销 
        /// </summary>
        public int SchemeStatus { get; set; }
        /// <summary>
        /// 申请人
        /// </summary>
        public string SchemsName { get; set; }
        /// <summary>
        /// 审核人
        /// </summary>
        public string Auditor { get; set; }

    }
}
