using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace LowCodeProject.Helper.BaiduyunHelper
{
    public class ReturnResultDetect
    {
        public static int GetFaceAddReturnResult(string strjson)
        {
            int BackResult = 0;
            SearchReturn feedback = JsonConvert.DeserializeObject<SearchReturn>(strjson);
            if (feedback.result == null)
            {
                BackResult = 0;
            }
            else
            {
                BackResult = 1;
            }
            return BackResult;
        }
        public static string GetFaceSearchReturnResult(string strjson)
        {
            string BackResult = "";
            int score = 0;
            //将收到的json字符串转化成SearchReturn类型的变量，即反序列化
            SearchReturn feedback = JsonConvert.DeserializeObject<SearchReturn>(strjson);
            if (feedback.result == null)
            {
                BackResult = "_0";   //未检测到人脸
            }
            else
            {
                score = Convert.ToInt32(feedback.result.user_list[0].score);
                if (score < 80)
                {
                    BackResult = "_1";   //人脸不匹配
                }
                else
                {
                    BackResult = feedback.result.user_list[0].user_id;
                }
            }
            return BackResult;
        }
    }
}
