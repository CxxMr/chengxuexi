using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;

namespace LowCodeProject.DTO
{
    public class UserRoleModelDto : AuditedEntityDto<int>
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
