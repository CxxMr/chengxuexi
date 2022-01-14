using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;

namespace LowCodeProject.DTO
{
    public class DepartmentDto : AuditedEntityDto<int>
    {
        /// <summary>
        /// 部们ID
        /// </summary>
        //public int DepartmentId { get; set; }
        /// <summary>
        /// 部门名称
        /// </summary>
        public string DepartmenName { get; set; }
        /// <summary>
        /// 部门编号
        /// </summary>
        public string DepartmenCode { get; set; }
        /// <summary>
        /// 父级id
        /// </summary>
        public int DepartmenTid { get; set; }
    }
}
