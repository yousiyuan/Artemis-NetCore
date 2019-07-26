using BeetleX.FastHttpApi;
using BeetleX.FastHttpApi.Data;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Oseage.XTKJ.FastApiService.Filters;
using Oseage.XTKJ.FastApiService.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oseage.XTKJ.FastApiService.Controllers
{
    [Options(AllowOrigin = "*")]
    [SkipFilter(typeof(GlobalAuthorizeHandler))]
    [Controller(BaseUrl = "api/public", SingleInstance = true)]
    public class PublicController
    {
        /// <summary>
        /// 获取token
        /// </summary>
        /// <param name="name">用户名</param>
        /// <param name="role">角色</param>
        [Get]
        [RouteTemplate("{name}-{role}")]
        public Task<TextResult> GetToken(string name, string role)
        {
            return Task.FromResult(new TextResult(Program.JwtUtil.CreateToken(name, role)));
        }

        /// <summary>
        /// url
        /// </summary>
        [Get(Route = "{name}-{value}")]
        public Task<TextResult> SayHello(string name, string value, IHttpContext context)
        {
            Console.WriteLine("=======================SayHello=======================");
            var result = new { Hello = "hello " + name + "=" + value, Time = DateTime.Now };
            Console.WriteLine(JsonConvert.SerializeObject(context.Request.Header));
            Console.WriteLine(JsonConvert.SerializeObject(result));
            return Task.FromResult(new TextResult(JsonConvert.SerializeObject(result)));
        }

        /// <summary>
        /// url
        /// </summary>
        [Get]
        [RouteTemplate("{name}-{value}-{gaga}")]
        public Task<JsonResult> GetJsonData(string name, string value, string gaga, IHttpContext context)
        {
            Console.WriteLine("=======================GetJsonData=======================");
            var result = new { Hello = "hello " + name + "=" + value, Time = DateTime.Now, info = gaga };
            Console.WriteLine(JsonConvert.SerializeObject(context.Request.Header));
            Console.WriteLine(JsonConvert.SerializeObject(result));
            return Task.FromResult(new JsonResult(result));
        }

        /// <summary>
        /// application/json
        /// </summary>
        [Post]
        [JsonDataConvert]
        public Task<JsonResult> Post(object body, IHttpContext context)
        {
            Console.WriteLine("=======================Post=======================");
            var json = JObject.FromObject(body);
            Console.WriteLine(context.Data);
            return Task.FromResult(new JsonResult($"{json["name"]}：{json["value"]}"));
        }

        /// <summary>
        /// application/x-www-form-urlencoded
        /// </summary>
        [Post]
        [FormUrlDataConvert]
        public Task<JsonResult> PostFormReturnJson(string name, string value, IHttpContext context)
        {
            Console.WriteLine("=======================PostFormReturnJson=======================");
            Console.WriteLine(context.Data);
            return Task.FromResult(new JsonResult(new { name = name, value = value }));
        }

        /// <summary>
        /// application/x-www-form-urlencoded
        /// </summary>
        [Post]
        [FormUrlDataConvert]
        public Task<TextResult> PostForm(string name, string value, IHttpContext context)
        {
            Console.WriteLine("=======================PostForm=======================");
            Console.WriteLine(context.Data);
            return Task.FromResult(new TextResult($"{name}={value}"));
        }

        /// <summary>
        /// multipart/form-data
        /// </summary>
        [Post]
        [MultiDataConvert]
        public Task<TextResult> UploadFile(string remark, IHttpContext context)
        {
            Console.WriteLine("=======================UploadFile=======================");
            foreach (var file in context.Request.Files)
                using (System.IO.Stream stream = System.IO.File.Create(file.FileName))
                {
                    Console.WriteLine(file.FileName);
                    file.Data.CopyTo(stream);
                }
            Console.WriteLine("remark");
            return Task.FromResult(new TextResult($"{DateTime.Now} {remark} {string.Join(",", (from fs in context.Request.Files select fs.FileName).ToArray())}"));
        }

        /// <summary>
        /// 自定义：读取数据流
        /// </summary>
        [Post]
        [NoDataConvert]
        public Task<TextResult> PostStream(IHttpContext context)
        {
            Console.WriteLine("=======================PostStream=======================");
            string value = context.Request.Stream.ReadString(context.Request.Length);
            Console.WriteLine(value);
            return Task.FromResult(new TextResult(value));
        }
    }
}
