using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;


namespace LowCodeProject.Verification
{
    public class CreateUpDateUploadPictureDto
    {
        /// <summary>
        /// 主键ID
        /// </summary>
        // public int PictureId { get; set; }
        /// <summary>
        /// 文件名称
        /// </summary>
        [Required]
        public string FileName { get; set; }
        /// <summary>
        /// 文件路径
        /// </summary>
        [Required]
        public string FilePath { get; set; }
        /// <summary>
        /// 描述
        /// </summary>
        [Required]
        public string Description { get; set; }
        /// <summary>
        /// 文件类型
        /// </summary>
        [Required]
        public int FileType { get; set; }
        /// <summary>
        /// 0:可用 -1:不可用
        /// </summary>v
        [Required]
        public int Enable { get; set; }
        /// <summary>
        /// 上传人id
        /// </summary>
        [Required]
        public int CreateuserId { get; set; }
        /// <summary>
        /// 上传人姓名
        /// </summary>
        [Required]
        public string CreateTime { get; set; }
        /// <summary>
        /// 应用id
        /// </summary>
        [Required]
        public int ApplyTypeId { get; set; }
        /// <summary>
        /// 类型名称
        /// </summary>
        [Required]
        public string ApplyTypeName { get; set; }
    }
}
