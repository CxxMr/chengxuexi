using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace LowCodeProject.Helper.EmailHelper
{
    public  class MailHelper
    {
        private readonly Mail _mail;
        private readonly IHostingEnvironment _hostingEnvironment;
        public MailHelper(Mail mail,
            IHostingEnvironment hostingEnvironment)
        {
            _mail = mail;
            _hostingEnvironment = hostingEnvironment;
        }
        /// <summary>
        /// 发送邮件
        /// </summary>
        public static int PostEmails([FromForm] Mail mails)
         {
            //截取发件人邮箱地址从而判断Smtp的值
            string[] sArray = mails.fromPerson.Split(new char[2] { '@', '.' });
            if (sArray[1] == "qq")
            {
                mails.host = "smtp.qq.com";//如果是QQ邮箱则：smtp.qq.com,依次类推  163:smtp.163.com
            }
            else if (sArray[1] == "163")
            {
                mails.host = "smtp.163.com";//如果是QQ邮箱则：smtp.qq.com,依次类推  163:smtp.163.com
            }
            //将发件人邮箱带入MailAddress中初始化
            MailAddress mailAddress = new MailAddress(mails.fromPerson);
            //创建Email的Message对象
            MailMessage mailMessage = new MailMessage();

            //判断收件人数组中是否有数据
            if (mails.recipientArry.Any())
            {
                //循环添加收件人地址
                foreach (var item in mails.recipientArry)
                {
                    if (!string.IsNullOrEmpty(item))
                        mailMessage.To.Add(item.ToString());
                }
            }
            //判断抄送地址数组是否有数据
            if (mails.mailCcArray.Any())
            {
                //循环添加抄送地址
                foreach (var item in mails.mailCcArray)
                {
                    if (!string.IsNullOrEmpty(item))
                        mailMessage.To.Add(item.ToString());
                }
            }
            //发件人邮箱
            mailMessage.From = mailAddress;
            //标题
            mailMessage.Subject = mails.mailTitle;
            //编码
            mailMessage.SubjectEncoding = Encoding.UTF8;
            //正文
            mailMessage.Body = mails.mailBody;
            //正文编码
            mailMessage.BodyEncoding = Encoding.Default;
            //邮件优先级
            mailMessage.Priority = MailPriority.High;
            //正文是否是html格式
            mailMessage.IsBodyHtml = mails.isbodyHtml;
            //取得Web根目录和内容根目录的物理路径
            string webRootPath = string.Empty;
            //添加附件
            foreach (IFormFile item in mails.files)
            {
                //路径拼接
                //webRootPath = _hostingEnvironment.WebRootPath + "\\" + "upload-file" + "\\" + DateTime.Now.ToString("yyyyMMddHHmmssfff") + Path.GetFileNameWithoutExtension(item.FileName) + Path.GetExtension(item.FileName).ToLower();
                //创建文件流
                //using (var FileStream = new FileStream(webRootPath, FileMode.Create))
                //{
                //拷贝文件流
                //await item.CopyToAsync(FileStream);
                //释放缓存
                //FileStream.Flush();
                //}
                //再根据路径打开文件，得到文件流
                //FileStream stream = new FileStream(webRootPath, FileMode.Open);

                //添加至附件中
                //mailMessage.Attachments.Add(new Attachment(stream, item.FileName));
                mailMessage.Attachments.Add(new Attachment(item.OpenReadStream(), item.FileName));
            };

            //实例化一个Smtp客户端
            SmtpClient smtp = new SmtpClient();
            //将发件人的邮件地址和客户端授权码带入以验证发件人身份
            smtp.Credentials = new System.Net.NetworkCredential(mails.fromPerson, mails.code);
            //指定SMTP邮件服务器
            smtp.Host = mails.host;

            //邮件发送到SMTP服务器
            smtp.Send(mailMessage);

            return 1;

        }



    }
}
