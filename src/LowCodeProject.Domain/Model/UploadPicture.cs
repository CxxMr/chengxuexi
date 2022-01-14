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
    public class UploadPicture : AggregateRoot<int>
    {
        /// <summary>
        /// 主键ID
        /// </summary>
       // public int PictureId { get; set; }
        /// <summary>
        /// 文件名称
        /// </summary>
        public string FileName { get; set; }
        /// <summary>
        /// 文件路径
        /// </summary>
        public string FilePath { get; set; }
        /// <summary>
        /// 描述
        /// </summary>
        public string Description { get; set; }
        /// <summary>
        /// 文件类型
        /// </summary>
        public int FileType { get; set; }
        /// <summary>
        /// 0:可用 -1:不可用
        /// </summary>v
        public int Enable { get; set; }
        /// <summary>
        /// 上传人id
        /// </summary>
        public int CreateuserId { get; set; }
        /// <summary>
        /// 上传人姓名
        /// </summary>
        public string CreateTime { get; set; }
        /// <summary>
        /// 应用id
        /// </summary>
        public int ApplyTypeId { get; set; }
        /// <summary>
        /// 类型名称
        /// </summary>
        public string ApplyTypeName { get; set; }




    }
}
