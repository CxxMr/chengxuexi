using Nancy.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Text;

namespace LowCodeProject.Helper.BaiduyunHelper
{
    internal class BaiDuYun_Recognition
    {
        // 调用getAccessToken()获取的 access_token建议根据expires_in 时间 设置缓存
        // 返回token示例
        public static String TOKEN = "24.adda70c11b9786206253ddb70affdc46.2592000.1493524354.282335-1234567";

        // 百度云中开通对应服务应用的 API Key 建议开通应用的时候多选服务
        private static String clientId = "*********";
        // 百度云中开通对应服务应用的 Secret Key
        private static String clientSecret = "**********";


        /// <summary>
        /// 连接百度云人脸识别
        /// </summary>
        /// <returns></returns>
        public static string  GetAccessToken()
        {
            String authHost = "https://aip.baidubce.com/oauth/2.0/token";
            HttpClient client = new HttpClient();
            List<KeyValuePair<String, String>> paraList = new List<KeyValuePair<string, string>>();
            paraList.Add(new KeyValuePair<string, string>("grant_type", "client_credentials"));
            paraList.Add(new KeyValuePair<string, string>("client_id", clientId));
            paraList.Add(new KeyValuePair<string, string>("client_secret", clientSecret));

            HttpResponseMessage response = client.PostAsync(authHost, new FormUrlEncodedContent(paraList)).Result;
            String result = response.Content.ReadAsStringAsync().Result;
            Console.WriteLine(result);


            //获取返回的字符串
            //string test = AccessToken.getAccessToken();
            //Response.Write(test + "<br/>");


            //获取返回的Access_Token
            string Access_Token = "";
            JavaScriptSerializer Jss = new JavaScriptSerializer();
            Dictionary<string, object> DicText = (Dictionary<string, object>)Jss.DeserializeObject(result);
            //如果返回值中含有access_token，则将其值赋予Access_Token，不存在则说明获取失败。
            if (!DicText.ContainsKey("access_token"))
            {
                Access_Token = "获取Access_Token失败";
            }
            else
            {
                Access_Token = DicText["access_token"].ToString();
            }

            //Session["Token"] = Access_Token;
            //Response.Write(Access_Token);
            return Access_Token;
        }

        /// <summary>
        /// 人脸搜索
        /// </summary>
        /// <param name="token"></param>
        /// <param name="strbase64"></param>
        /// <returns></returns>
        public static string Search(string token, string strbase64)
        {
            //服务器地址，Access_Token作为凭证
            string host = "https://aip.baidubce.com/rest/2.0/face/v3/search?access_token=" + token;
            Encoding encoding = Encoding.Default;
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(host);
            request.Method = "post";
            request.KeepAlive = true;
            //序列化，生成json字符串
            Dictionary<String, String> dic = new Dictionary<string, string>();
            dic.Add("image", strbase64);
            dic.Add("image_type", "BASE64");
            dic.Add("group_id_list", "Users");
            dic.Add("quality_control", "LOW");
            dic.Add("liveness_control", "NONE");
            JavaScriptSerializer js = new JavaScriptSerializer();
            String str = js.Serialize(dic);

            byte[] buffer = encoding.GetBytes(str);
            request.ContentLength = buffer.Length;
            request.GetRequestStream().Write(buffer, 0, buffer.Length);
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            StreamReader reader = new StreamReader(response.GetResponseStream(), Encoding.Default);
            string result = reader.ReadToEnd();
            Console.WriteLine("人脸搜索:");
            Console.WriteLine(result);
            return result;
        }



        /// <summary>
        /// 人脸注册
        /// </summary>
        /// <param name="token"></param>
        /// <param name="base64"></param>
        /// <param name="tel"></param>
        /// <returns></returns>
        /// 参数说明：token->之前获取的Access_Token，base64->图片数据，tel->人脸编号
        public static string add(string token, string base64, string tel)
        {
            //string token = "[调用鉴权接口获取的token]";
            string host = "https://aip.baidubce.com/rest/2.0/face/v3/faceset/user/add?access_token=" + token;
            Encoding encoding = Encoding.Default;
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(host);
            request.Method = "post";
            request.KeepAlive = true;

            //将数据写入json字符串中
            Dictionary<String, String> dic = new Dictionary<string, string>();
            dic.Add("image", base64);
            dic.Add("image_type", "BASE64");
            //人脸库里的分组名
            dic.Add("group_id", "Users");
            //这个人脸的编号
            dic.Add("user_id", tel);
            //图片质量检测，Low表示可以接受较低画质的人脸数据
            dic.Add("quality_control", "LOW");
            //活体检测，这里只是一个小Demo，所以没有添加活体检测的功能
            dic.Add("liveness_control", "NONE");
            JavaScriptSerializer js = new JavaScriptSerializer();
            String str = js.Serialize(dic);

            byte[] buffer = encoding.GetBytes(str);
            request.ContentLength = buffer.Length;
            request.GetRequestStream().Write(buffer, 0, buffer.Length);
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            StreamReader reader = new StreamReader(response.GetResponseStream(), Encoding.Default);
            string result = reader.ReadToEnd();
            Console.WriteLine("人脸注册:");
            Console.WriteLine(result);
            return result;
        }


    }
}
