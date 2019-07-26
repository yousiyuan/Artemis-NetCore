using BeetleX.FastHttpApi;
using System;
using System.Collections.Generic;
using System.Text;

namespace Oseage.XTKJ.FastApiService.Utility
{
    public static class CookieUtility
    {
        /// <summary>
        /// 设置Cookie
        /// </summary>
        public static void SetCookie(this IHttpContext context, string key, string value)
        {
            context.Response.SetCookie(key, value);
        }

        /// <summary>
        /// 获取Cookie
        /// </summary>
        public static string GetCookie(this IHttpContext context, string key)
        {
            return context.Request.Cookies[key];
        }
    }
}
