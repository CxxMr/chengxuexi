using System;
using System.Collections.Generic;
using System.Text;

namespace LowCodeProject.HelperEnum
{
    /// <summary>
    /// 状态码
    /// </summary>
    public enum HttpCode
    {
        /// <summary>
        /// 成功
        /// </summary>
        成功 = 200,
        /// <summary>
        /// 该请求是无效的，详细的错误信息会说明原因
        /// </summary>
        请求参数错误 = 400,
        /// <summary>
        /// 验证失败，详细的错误信息会说明原因
        /// </summary>
        未授权 = 401,
        /// <summary>
        /// 被拒绝调用，详细的错误信息会说明原因
        /// </summary>
        服务器拒绝请求 = 403,
        /// <summary>
        /// 服务器找不到请求的地址
        /// </summary>
        未找到 = 404,
        /// <summary>
        /// 群容量超出上限，禁止请求此方法
        /// </summary>
        请求方法不支持 = 405,
        /// <summary>
        /// 超出了调用频率限制，详细的错误信息会说明原因
        /// </summary>
        请求频率超限 = 429,
        /// <summary>
        /// 服务器内部出错了，请联系我们尽快解决问题
        /// </summary>
        服务器内部错误 = 500,
        /// <summary>
        /// 服务器在运行，本次请求响应超时，请稍后重试
        /// </summary>
        网关超时 = 504,
        /// <summary>
        /// 失败
        /// </summary>
        失败=300
    }
}
