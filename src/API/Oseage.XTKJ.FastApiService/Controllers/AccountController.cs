using BeetleX.FastHttpApi;
using BeetleX.FastHttpApi.Clients;
using BeetleX.FastHttpApi.Data;
using Newtonsoft.Json.Linq;
using Oseage.XTKJ.FastApiService.Filters;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Oseage.XTKJ.FastApiService.Controllers
{
    [Options(AllowOrigin = "*")]
    [SkipFilter(typeof(GlobalAuthorizeHandler))]
    [Controller(BaseUrl = "api/account", SingleInstance = true)]
    public class AccountController
    {
        [Post]
        [JsonDataConvert]
        public Task<JsonResult> Login(object body, IHttpContext context)
        {
            Console.WriteLine("=======================Login=======================");
            var json = JObject.FromObject(body);
            var userName = json["userName"];
            var password = json["password"];
            var verifyCode = json["verifyCode"];
            Console.WriteLine(userName);
            Console.WriteLine(password);
            Console.WriteLine(verifyCode);
            return Task.FromResult(new JsonResult(new { msg = "登录成功", code = 123 }));
        }
    }
}
