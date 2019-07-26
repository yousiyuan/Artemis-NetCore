using BeetleX;
using BeetleX.Buffers;
using BeetleX.EventArgs;
using BeetleX.FastHttpApi;
using Microsoft.Extensions.Hosting;
using Oseage.XTKJ.FastApiService.Areas.COM.Controllers;
using Oseage.XTKJ.FastApiService.Controllers;
using Oseage.XTKJ.FastApiService.Filters;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Oseage.XTKJ.FastApiService.App_Code
{
    public class HttpServerHost : IHostedService
    {
        private HttpApiServer mApiServer;

        public virtual Task StartAsync(CancellationToken cancellationToken)
        {
            mApiServer = new HttpApiServer();
            mApiServer.Options.Port = 9090;
            mApiServer.Options.Filters.Add(new GlobalAuthorizeHandler());
            mApiServer.Options.Filters.Add(new GlobalExceptionHandler());
            mApiServer.Options.UrlIgnoreCase = true;
            mApiServer.Options.LogLevel = LogType.Warring;
            mApiServer.Options.LogToConsole = true;
            
            // TODO:
            //   配置HTTPS访问
            //options.SSL = true;
            //options.CertificateFile = "";
            //options.CertificatePassword = "";

            mApiServer.Options.BufferPoolMaxMemory = 500;
            mApiServer.Options.MaxConnections = 100000;
            mApiServer.Options.Statistical = false;
            mApiServer.Options.PrivateBufferPool = true;
            mApiServer.Options.SetDebug();

            var assemblyCollection = new Assembly[] { typeof(Program).Assembly };
            mApiServer.Register(assemblyCollection);
            mApiServer.Open();

            return Task.CompletedTask;
        }

        public virtual Task StopAsync(CancellationToken cancellationToken)
        {
            mApiServer.BaseServer.Dispose();
            return Task.CompletedTask;
        }
    }
}
