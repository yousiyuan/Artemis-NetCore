using BeetleX.FastHttpApi;
using System;
using System.Collections.Generic;
using System.Text;

namespace Oseage.XTKJ.FastApiService.Utility
{
    public static class HeaderUtility
    {
        /// <summary>
        /// 设置Header
        /// </summary>
        public static void SetHeader(this IHttpContext context, string key, string value)
        {
            context.Response.Header[key] = value;
        }

        /// <summary>
        /// 读取Header
        /// </summary>
        public static string GetHeader(this IHttpContext context, string key)
        {
            return context.Request.Header[key];
        }
    }
}
