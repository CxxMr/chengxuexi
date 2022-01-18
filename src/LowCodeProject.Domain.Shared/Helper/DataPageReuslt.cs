using System;
using System.Collections.Generic;
using System.Text;

namespace LowCodeProject.Helper
{
    /// <summary>
    /// 返回的数据格式类型
    /// </summary>

    public class DataPageReuslt<T>
    {
        /// <summary>
        /// 返回状态码  
        /// </summary> 
        public HelperEnum.HttpCode TypeCode { get; set; }
        /// <summary>
        /// 返回数据
        /// </summary>
        public T Result { get; set; }
        /// <summary>
        /// 返回信息
        /// </summary>
        public string Message { get; set; }

        public int Total { get; set; }
    }
}
