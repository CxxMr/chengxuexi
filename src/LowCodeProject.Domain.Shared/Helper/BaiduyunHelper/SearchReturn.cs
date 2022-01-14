using System;
using System.Collections.Generic;
using System.Text;

namespace LowCodeProject.Helper.BaiduyunHelper
{
    public class SearchReturn
    {
        public int error_code { get; set; }
        public string error_msg { get; set; }
        public long log_id { get; set; }
        public int timestamp { get; set; }
        public int cached { get; set; }
        public Result result { get; set; }
    }

    public class Result
    {
        public string face_token { get; set; }
        public User_List[] user_list { get; set; }
    }
    public class User_List
    {
        public string group_id { get; set; }
        public string user_id { get; set; }
        public string user_info { get; set; }
        public float score { get; set; }
    }

}
