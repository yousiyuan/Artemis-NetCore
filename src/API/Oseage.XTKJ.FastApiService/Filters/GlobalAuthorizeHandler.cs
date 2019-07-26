using BeetleX.FastHttpApi;
using Oseage.XTKJ.FastApiService.Utility;
using System;
using System.Collections.Generic;
using System.Text;

namespace Oseage.XTKJ.FastApiService.Filters
{
    public class GlobalAuthorizeHandler : FilterAttribute
    {
        public override bool Executing(ActionContext context)
        {
            //获取Header传递过来的token
            string authorization = context.HttpContext.GetHeader(HeaderTypeFactory.AUTHORIZATION);
            var user = Program.JwtUtil.GetUserInfo(authorization);
            if (user.HasValue)
            {
                return true;
            }
            else
            {
                context.Result = new TextResult("token not found");
                return false;
            }
        }
    }
}
