using System;
using System.Linq;
using System.Reflection;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Oseage.XTKJ.FastApiService.App_Code;
using Oseage.XTKJ.FastApiService.Utility;

namespace Oseage.XTKJ.FastApiService
{
    class Program
    {
        public static JwtUtility JwtUtil = new JwtUtility();

        static void Main(string[] args)
        {
            var builder = new HostBuilder()
                     .ConfigureServices((hostContext, services) =>
                     {
                         services.AddHostedService<HttpServerHost>();
                     });
            builder.Build().Run();
        }
    }
}
