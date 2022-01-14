using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Entities;
namespace LowCodeProject.Model
{
    /// <summary>
    /// 权限
    /// </summary>
    public class MyPowerModel : AggregateRoot<int>
    {
        /// <summary>
        /// 权限id
        /// </summary>
      //  public int PowerId { get; set; }
        /// <summary>
        /// 权限名称
        /// </summary>
        public string PowerName { get; set; }

    }
}
