using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;


namespace LowCodeProject.Verification
{
    public class CreateUpDateTreeModelDto
    {
        /// <summary>
        /// 递归树的主键Id
        /// </summary>
        //  public int TreeId { get; set; }
        /// <summary>
        ///  递归名称
        /// </summary>
        [Required]
        public string TreeName { get; set; }
        /// <summary>
        /// 递归父级Id
        /// </summary>
        [Required]
        public int TreeTid { get; set; }
        /// <summary>
        /// 详情信息
        /// </summary>
        [Required]
        public string TreeDetail { get; set; }
        /// <summary>
        /// 节点类型, 文件夹/页面/按钮
        /// </summary>
        [Required]
        public string Node_type { get; set; }
        /// <summary>
        /// 页面对应的地址文件夹/按钮
        /// </summary>
        [Required]
        public string Link_url { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Required]
        public string Level { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Required]
        public string Path { get; set; }
    }
}
