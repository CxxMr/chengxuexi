using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Entities;
namespace LowCodeProject.Model
{
    /// <summary>
    /// 角色
    /// </summary>
    public class  MyRoleModel : BasicAggregateRoot<int>
    {
        /// <summary>
        /// 角色id
        /// </summary>
       // public int RoleId { get; set; }
        /// <summary>
        /// 角色名称
        /// </summary>
        public string RoleName { get; set; }
        /// <summary>
        /// 角色详情
        /// </summary>
        public string RoleDateil { get; set; }

    }
}
