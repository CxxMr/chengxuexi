using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Services;

namespace LowCodeProject.Login
{
    public class TokenDto
    {
        public string Msg { get; set; }
        public bool state { get; set; }
        public string token { get; set; }
    }
}
