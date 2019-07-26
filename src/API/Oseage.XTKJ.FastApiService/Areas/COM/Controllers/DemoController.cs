using BeetleX.FastHttpApi;
using BeetleX.FastHttpApi.Data;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oseage.XTKJ.FastApiService.Areas.COM.Controllers
{
    [Controller(BaseUrl = "/com/demo", SingleInstance = true)]
    public class DemoController
    {
        [Post]
        [FormUrlDataConvert]
        public Task<JsonResult> GetQuestionList(IHttpContext context)
        {
            Console.WriteLine("=======================GetQuestionList=======================");
            var to = context.Request.Header["Authorization"];
            Console.WriteLine(to);
            return Task.FromResult(new JsonResult(new List<string> { "流年·公子", "流年·莉娜" }));
        }
    }
}
