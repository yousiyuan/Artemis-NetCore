//*******************************
// Create By 流年 公子
// Date 2019-07-03 13:49
// Code Generate By SmartCode
// Code Generate Github : https://github.com/Ahoo-Wang/SmartCode
//*******************************
using System;
using System.IO;
using System.Reflection;
using AspectCore.Extensions.DependencyInjection;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Swashbuckle.AspNetCore.Swagger;
using OSeage.QTI.Service;
using OSeage.XTKJ.API.Filters;
using SmartSql.ConfigBuilder;
using OSeage.XTKJ.API.SwaggerExtension;

namespace OSeage.XTKJ.API
{
    public class Startup
    {

        public IConfiguration Configuration { get; }

        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public IServiceProvider ConfigureServices(IServiceCollection services)
        {
            services.AddMvc(options =>
            {
                options.Filters.Add<GlobalExceptionFilter>();
                options.Filters.Add<GlobalValidateModelFilter>();
            }).SetCompatibilityVersion(CompatibilityVersion.Latest);


            RegisterRepository(services);
            RegisterService(services);


            RegisterSwagger(services);

            return services.BuildAspectInjectorProvider();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            app.UseMvc();
            ConfigureSwagger(app);
        }


        private void RegisterRepository(IServiceCollection services)
        {
            //注入oseage_lms_v2_qti_db库的SmartSql实例以及对应的仓储对象
            services
                .AddSmartSql((builder) =>
                {
                    builder.UseAlias("OSEAGE_QTI");
                    builder.UseXmlConfig(ResourceType.File, "SmartSqlConfig/MSSQL/SmartSqlMapConfig-QTI.xml");
                })
                .AddRepositoryFromAssembly(options =>
                {
                    options.SmartSqlAlias = "OSEAGE_QTI";
                    options.AssemblyString = "OSeage.QTI.Repository";
                    options.Filter = (type) => type.Namespace == "OSeage.QTI.Repository";
                    options.ScopeTemplate = "I{Scope}Repository";
                }).AddInvokeSync(options => { });
            //注入LMS_COM库的SmartSql实例以及对应的仓储对象
            services
                .AddSmartSql((builder) =>
                {
                    builder.UseAlias("OSEAGE_LMS_COM");
                    builder.UseXmlConfig(ResourceType.File, "SmartSqlConfig/MSSQL/SmartSqlMapConfig-COM.xml");
                })
                .AddRepositoryFromAssembly(options =>
                {
                    options.SmartSqlAlias = "OSEAGE_LMS_COM";
                    options.AssemblyString = "OSeage.LMS.COM.Repository";
                    options.Filter = (type) => type.Namespace == "OSeage.LMS.COM.Repository";
                    options.ScopeTemplate = "I{Scope}Repository";
                }).AddInvokeSync(options => { });
            //注入LMS_ERSCP库的SmartSql实例以及对应的仓储对象
            services
                .AddSmartSql((builder) =>
                {
                    builder.UseAlias("OSEAGE_LMS_ERSCP");
                    builder.UseXmlConfig(ResourceType.File, "SmartSqlConfig/MSSQL/SmartSqlMapConfig-ERSCP.xml");
                })
                .AddRepositoryFromAssembly(options =>
                {
                    options.SmartSqlAlias = "OSEAGE_LMS_ERSCP";
                    options.AssemblyString = "OSeage.LMS.ERSCP.Repository";
                    options.Filter = (type) => type.Namespace == "OSeage.LMS.ERSCP.Repository";
                    options.ScopeTemplate = "I{Scope}Repository";
                })
                .AddInvokeSync(options => { });
        }

        private void RegisterService(IServiceCollection services)
        {
            //注入OSEAGE_QTI服务
            var assembly = Assembly.Load("OSeage.QTI.Service");
            var allTypes = assembly.GetTypes();
            foreach (var type in allTypes)
            {
                services.AddSingleton(type);
            }
            //注入OSEAGE_LMS_COM服务
            assembly = Assembly.Load("OSeage.LMS.COM.Service");
            allTypes = assembly.GetTypes();
            foreach (var type in allTypes)
            {
                services.AddSingleton(type);
            }
            //注入OSEAGE_LMS_ERSCP服务
            assembly = Assembly.Load("OSeage.LMS.ERSCP.Service");
            allTypes = assembly.GetTypes();
            foreach (var type in allTypes)
            {
                services.AddSingleton(type);
            }
        }



        #region Swagger

        const string SERVICE_NAME_QTI = "OSeage.XTKJ.API.Areas.QTI";
        const string DOC_NAME_QTI = "v1.qti";
        const string SERVICE_NAME_COM = "OSeage.XTKJ.API.Areas.COM";
        const string DOC_NAME_COM = "v1.com";
        const string SERVICE_NAME_ERSCP = "OSeage.XTKJ.API.Areas.ERSCP";
        const string DOC_NAME_ERSCP = "v1.erscp";

        private void RegisterSwagger(IServiceCollection services)
        {
            services.AddSwaggerGen(options =>
            {
                options.SwaggerDoc(DOC_NAME_QTI, new Info
                {
                    Version = "v1",
                    Title = "QTI接口文档说明",
                    Description = "http://localhost:8888/qti/",
                    TermsOfService = "",
                    Contact = new Contact
                    {
                        Email = "mijinchenyuan@163.com",
                        Name = "流年·公子"
                    },
                    License = new License
                    {
                        Name = "深圳市学堂科技有限公司",
                        Url = "http://lacing5453.zhaoshang100.com/"
                    }
                });

                options.SwaggerDoc(DOC_NAME_COM, new Info
                {
                    Version = "v1",
                    Title = "COM接口文档说明",
                    Description = "http://localhost:8888/com/",
                    TermsOfService = "",
                    Contact = new Contact
                    {
                        Email = "mijinchenyuan@163.com",
                        Name = "流年·公子"
                    },
                    License = new License
                    {
                        Name = "深圳市学堂科技有限公司",
                        Url = "http://lacing5453.zhaoshang100.com/"
                    }
                });

                options.SwaggerDoc(DOC_NAME_ERSCP, new Info
                {
                    Version = "v1",
                    Title = "ERSCP接口文档说明",
                    Description = "http://localhost:8888/erscp/",
                    TermsOfService = "",
                    Contact = new Contact
                    {
                        Email = "mijinchenyuan@163.com",
                        Name = "流年·公子"
                    },
                    License = new License
                    {
                        Name = "深圳市学堂科技有限公司",
                        Url = "http://lacing5453.zhaoshang100.com/"
                    }
                });

                //按照路由，把不同区域下的API归到对应的文档下
                options.DocInclusionPredicate((docName, apiDesc) =>
                {
                    var isInclusion = docName.Contains(apiDesc.GetAreaName().ToLower());
                    if (!isInclusion)
                    {
                        Console.WriteLine(docName);
                        Console.WriteLine(apiDesc.GetAreaName().ToLower());
                    }
                    return isInclusion;
                });


                //分组排序相关
                //options.TagActionsBy(apiDesc => apiDesc.GetAreaNameList());
                options.OrderActionsBy(apiDesc => apiDesc.GetAreaName());


                //swaggerUI中加入授权请求
                options.OperationFilter<HttpAuthenticationOperationFilter>();
                options.CustomSchemaIds((type) => type.FullName);


                //基于XML，将操作、参数和模式 注入人性化描述
                var filePath = Path.Combine(AppContext.BaseDirectory, $"{SERVICE_NAME_QTI}.xml");
                if (File.Exists(filePath))
                    options.IncludeXmlComments(filePath);

                filePath = Path.Combine(AppContext.BaseDirectory, $"{SERVICE_NAME_COM}.xml");
                if (File.Exists(filePath))
                    options.IncludeXmlComments(filePath);

                filePath = Path.Combine(AppContext.BaseDirectory, $"{SERVICE_NAME_ERSCP}.xml");
                if (File.Exists(filePath))
                    options.IncludeXmlComments(filePath);
            });
        }

        private void ConfigureSwagger(IApplicationBuilder app)
        {
            app.UseSwagger(c =>
            {

            });
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint($"/swagger/{DOC_NAME_QTI}/swagger.json", SERVICE_NAME_QTI);
                c.SwaggerEndpoint($"/swagger/{DOC_NAME_COM}/swagger.json", SERVICE_NAME_COM);
                c.SwaggerEndpoint($"/swagger/{DOC_NAME_ERSCP}/swagger.json", SERVICE_NAME_ERSCP);

                //默认折叠
                //c.DocExpansion(Swashbuckle.AspNetCore.SwaggerUI.DocExpansion.None);

                //设置后直接输入IP就可以进入接口文档
                //c.RoutePrefix = string.Empty;
            });
        }

        #endregion
    }
}
