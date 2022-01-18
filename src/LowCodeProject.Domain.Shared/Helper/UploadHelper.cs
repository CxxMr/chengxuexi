using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

namespace LowCodeProject.Helper
{
    public class UploadHelper
    {

          ///文件上传
         public static  string Upload(IFormFile file)
        {
            string Rootdir = AppContext.BaseDirectory.Split(@"\bin\")[0];
            string FileName = DateTime.Now.ToString("yyyyMMddHHmmssffff") + System.IO.Path.GetExtension(file.FileName);
            var Path = Rootdir + @"\Upload\" + FileName;
            using(System.IO.FileStream  fs =System.IO.File.Create(Path))
            {
                file.CopyTo(fs);
                fs.Flush();//清空文件流
            }
         //   var url= "https://localhost:44390/" + Path;
            var url =  Path;
            return url;
        }



    }
}
