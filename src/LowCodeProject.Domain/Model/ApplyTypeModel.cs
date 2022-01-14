using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Entities;
namespace LowCodeProject.Model
{

    /// <summary>
    /// 应用类型
    /// </summary>
    public class ApplyTypeModel: AggregateRoot<int>
    {
        ///// <summary>
        ///// id
        ///// </summary>
        //public int ApplyTypeId { get; set; } 
        /// <summary>
        /// 类型名称
        /// </summary>
        public string ApplyTypeName { get; set; }
        /// <summary>
        /// 类型图片
        /// </summary>
        public string ApplyTypeImg { get; set; }
        /// <summary>
        /// 创建时间
        /// </summary>
        public DateTime ApplyTypeCreateTime { get; set; } = DateTime.Now;

    }
}
