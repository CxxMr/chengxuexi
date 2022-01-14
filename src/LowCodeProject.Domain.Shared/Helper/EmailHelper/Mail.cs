using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Text;

namespace LowCodeProject.Helper.EmailHelper
{
    /// <summary>
    /// 邮件类 
    /// </summary>
    public class Mail
    {
        /// <summary>
        /// 发送人
        /// </summary>
        public string fromPerson { get; set; }

        /// <summary>
        /// 收件人地址(多人)
        /// </summary>
        public string[] recipientArry { get; set; }

        /// <summary>
        /// 抄送地址(多人)
        /// </summary>
        public string[] mailCcArray { get; set; }

        /// <summary>
        /// 标题
        /// </summary>
        public string mailTitle { get; set; }

        /// <summary>
        /// 正文
        /// </summary>
        public string mailBody { get; set; }

        /// <summary>
        /// 客户端授权码(可存在配置文件中)
        /// tpyepanokjruehgi
        /// </summary>
        public string code { get; set; }
        /// <summary>
        /// SMTP邮件服务器
        /// </summary>
        public string host { get; set; }

        /// <summary>
        /// 正文是否是html格式
        /// </summary>
        public bool isbodyHtml { get; set; }
        /// <summary>
        /// 接收文件
        /// </summary>
        public List<IFormFile> files { get; set; }
    }
}
