using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.JsonPatch.Operations;
using Microsoft.AspNetCore.Mvc.Controllers;
using Swashbuckle.AspNetCore.Swagger;
using Swashbuckle.AspNetCore.SwaggerGen;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;

namespace OSeage.XTKJ.API.SwaggerExtension
{
    /// <summary>
    /// 在 swagger请求头 添加Token参数
    /// </summary>
    public class HttpAuthenticationOperationFilter : IOperationFilter
    {
        public void Apply(Swashbuckle.AspNetCore.Swagger.Operation operation, OperationFilterContext context)
        {
            if (operation.Parameters == null)
                operation.Parameters = new List<IParameter>();

            if (context.ApiDescription.TryGetMethodInfo(out MethodInfo methodInfo))
                if (!methodInfo.CustomAttributes.Any(t => t.AttributeType == typeof(AllowAnonymousAttribute))
                        && !(methodInfo.ReflectedType.CustomAttributes.Any(t => t.AttributeType == typeof(AuthorizeAttribute))))
                    operation.Parameters.Add(new NonBodyParameter
                    {
                        Name = "Authorization",
                        In = "header",
                        Type = "string",
                        Required = true,
                        Description = "请输入Token，格式为：bearer XXX"
                    });
        }
    }
}
