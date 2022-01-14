using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Entities;
namespace LowCodeProject.Model
{
    public  class  MyUserModel : AggregateRoot<int>
    {
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

    }
}
