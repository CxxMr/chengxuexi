using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Entities;
namespace LowCodeProject.Model
{
    /// <summary>
    /// 订单
    /// </summary>
    public class MyOrederForm : AggregateRoot<int>
    {
        /// <summary>
        /// 订单编号
        /// </summary>
       // public int OrederId { get; set; }
        /// <summary>
        /// 订单名称
        /// </summary>
        public string OrederName { get; set; }
        /// <summary>
        /// 生成时间
        /// </summary>
        public DateTime OrederTime { get; set; }=DateTime.Now;
        /// <summary>
        /// 用户Id
        /// </summary>
        public int UserId { get; set; }
        /// <summary>
        /// 用户姓名
        /// </summary>
        public string UserName { get; set; }
        /// <summary>
        /// 1成功 -0失败
        /// </summary>
        public int OrederStatus { get; set; }

    }
}
