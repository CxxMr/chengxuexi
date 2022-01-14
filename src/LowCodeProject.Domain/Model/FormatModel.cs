using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Entities;
namespace LowCodeProject.Model
{
    /// <summary>
    /// 格式
    /// </summary>
   public  class FormatModel : AggregateRoot<int>
    {
        /// <summary>
        /// 格式id
        /// </summary>
        //public int FormatId { get; set; }
        /// <summary>
        /// 格式名称
        /// </summary>
        public string FormatName { get; set; }
        /// <summary>
        /// 格式详情
        /// </summary>
        public string FormatDetail { get; set; }

    }
}
