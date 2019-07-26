//*******************************
// Create By 流年 公子
// Date 2019-07-03 13:49
// Code Generate By SmartCode
// Code Generate Github : https://github.com/Ahoo-Wang/SmartCode
//*******************************
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.Extensions.Logging;
using OSeage.XTKJ.API.Exceptions;
using OSeage.XTKJ.API.Message;
using System.Net;

namespace  OSeage.XTKJ.API.Filters
{
    public class GlobalExceptionFilter : IExceptionFilter
    {
        private readonly IHostingEnvironment env;
        private readonly ILogger<GlobalExceptionFilter> logger;

        public GlobalExceptionFilter(IHostingEnvironment env, ILogger<GlobalExceptionFilter> logger)
        {
        this.env = env;
        this.logger = logger;
        }

        public void OnException(ExceptionContext context)
        {
        context.ExceptionHandled = true;
        var exception = context.Exception;
        logger.LogError(
        new EventId(exception.HResult),
        exception,
        exception.Message);
        string errorCode = "0001";
        if (exception is APIException) { errorCode = (exception as APIException).ErrorCode; }
        var errorResp = new ResponseMessage
        {
        Message = exception.Message,
        ErrorCode = errorCode,
        IsSuccess = false
        };
        var result = new JsonResult(errorResp)
        {
        StatusCode = (int)HttpStatusCode.OK
        };
        context.Result = result;

        }
        }
        }






