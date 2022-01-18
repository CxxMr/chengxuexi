using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;

namespace LowCodeProject.DTO
{
    public class ListUserDto : AuditedEntityDto<int>
    {
        /// <summary>
        /// 权限id
        /// </summary>
        //  public int PowerId { get; set; }
        /// <summary>
        /// 权限名称
        /// </summary>
        public string PowerName { get; set; }
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
        /// <summary>
        /// 用户id
        /// </summary>
        //  public int UserId { get; set; }
        /// <summary>
        /// 用户姓名
        /// </summary>
        public string UserName { get; set; }
        /// <summary>
        /// 用户账号
        /// </summary>
        public string UserAccount { get; set; }
        /// <summary>
        /// 用户密码
        /// </summary>
        public string UserPwd { get; set; }
        /// <summary>
        /// 用户手机号
        /// </summary>
        public string UserPhone { get; set; }
        /// <summary>
        /// 用户邮箱地址
        /// </summary>
        public string UserEmail { get; set; }
        /// <summary>
        /// 0:男 1:女  2:私密
        /// </summary>
        public int Sex { get; set; }
        /// <summary>
        /// 0:正常 1:异常 2:注销
        /// </summary>
        public int Status { get; set; }
        /// <summary>
        /// 经办时间
        /// </summary>
        public DateTime CreateTime { get; set; }
        /// <summary>
        /// 简介
        /// </summary>
        public string Detail { get; set; }
        /// <summary>
        /// 角色权限Id
        /// </summary>
        //  public int RolePowerId { get; set; }
        /// <summary>
        /// 角色Id
        /// </summary>
        /// <summary>
        /// 权限Id
        /// </summary>
    }
}
