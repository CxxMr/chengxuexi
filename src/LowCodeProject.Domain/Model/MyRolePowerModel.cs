using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Entities;
namespace LowCodeProject.Model
{
    /// <summary>
    /// 角色权限
    /// </summary>
    public class MyRolePowerModel : AggregateRoot<int>
    {
        /// <summary>
        /// 角色权限Id
        /// </summary>
      //  public int RolePowerId { get; set; }
        /// <summary>
        /// 角色Id
        /// </summary>
        public int RoleId { get; set; }
        /// <summary>
        /// 权限Id
        /// </summary>
        public int PowerId { get; set; }

    }
}
