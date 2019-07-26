using BeetleX.FastHttpApi;
using System;
using System.Collections.Generic;
using System.Text;

namespace Oseage.XTKJ.FastApiService.Filters
{
    public class GlobalExceptionHandler : FilterAttribute
    {
        public override void Executed(ActionContext context)
        {
            base.Executed(context);
            if (context.Exception != null)
            {
                context.Result = new TextResult(context.Exception.Message);
                context.Exception = null;
            }
        }
    }
}
