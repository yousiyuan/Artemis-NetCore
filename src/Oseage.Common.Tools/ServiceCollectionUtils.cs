using Microsoft.Extensions.DependencyInjection;
using SmartSql.ConfigBuilder;
using System;
using System.Reflection;

namespace Oseage.Common.Tools
{
    public static class ServiceCollectionUtils
    {
        /// <summary>
        /// 批量注册仓储对象
        /// </summary>
        /// <param name="alias">实例名称(适用于多库环境)</param>
        /// <param name="smartSqlMapConfig">SmartSqlMapConfig的路径</param>
        /// <param name="assemblyString">仓储接口的程序集的名称</param>
        /// <param name="namespaceString">仓储接口所在程序集的命名空间</param>
        public static IServiceCollection RegisterRepositoryFromAssembly(string alias, string smartSqlMapConfig, string assemblyString, string namespaceString)
        {
            var serviceCollection = new ServiceCollection();
            serviceCollection.AddSmartSql(builder =>
                {
                    builder.UseAlias(alias);
                    builder.UseXmlConfig(ResourceType.File, smartSqlMapConfig);
                })
                .AddRepositoryFromAssembly(options =>
                {
                    options.SmartSqlAlias = alias;
                    options.AssemblyString = assemblyString;
                    options.Filter = (type) => type.Namespace == namespaceString;
                    options.ScopeTemplate = "I{Scope}Repository";
                })
                .AddInvokeSync(options => { });
            return serviceCollection;
        }

        /// <summary>
        /// 批量注册仓储对象
        /// </summary>
        /// <param name="alias">实例名称(适用于多库环境)</param>
        /// <param name="smartSqlMapConfig">SmartSqlMapConfig的路径</param>
        /// <param name="assemblyString">仓储接口的程序集的名称</param>
        public static IServiceCollection RegisterRepositoryFromAssembly(string alias, string smartSqlMapConfig, string assemblyString)
        {
            var serviceCollection = new ServiceCollection();
            serviceCollection.AddSmartSql(builder =>
                {
                    builder.UseAlias(alias);
                    builder.UseXmlConfig(ResourceType.File, smartSqlMapConfig);
                })
                .AddRepositoryFromAssembly(options =>
                {
                    options.SmartSqlAlias = alias;
                    options.AssemblyString = assemblyString;
                    options.Filter = (type) => type.Namespace == assemblyString;
                    options.ScopeTemplate = "I{Scope}Repository";
                })
                .AddInvokeSync(options => { });
            return serviceCollection;
        }

        /// <summary>
        /// 注册服务
        /// </summary>
        /// <param name="namespaceString">服务对象所在的命名空间</param>
        public static IServiceCollection RegisterService(this IServiceCollection serviceCollection, string namespaceString)
        {
            var assembly = Assembly.Load(namespaceString);
            var allTypes = assembly.GetTypes();
            foreach (var type in allTypes)
            {
                serviceCollection.AddSingleton(type);
            }
            return serviceCollection;
        }
    }
}
