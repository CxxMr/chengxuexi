using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Entities;
namespace LowCodeProject.Model
{
    /// <summary>
    /// 部门
    /// </summary>
   public  class Department: AggregateRoot<int>
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
