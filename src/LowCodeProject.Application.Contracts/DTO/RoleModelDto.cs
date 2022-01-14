using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;

namespace LowCodeProject.DTO
{
    public class RoleModelDto : AuditedEntityDto<int>
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
