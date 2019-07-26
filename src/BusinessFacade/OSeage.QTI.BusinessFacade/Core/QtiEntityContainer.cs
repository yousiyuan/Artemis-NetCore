using Microsoft.Extensions.DependencyInjection;
using Oseage.Common.Tools;
using System;

namespace OSeage.QTI.BusinessFacade.Core
{
    public sealed class QtiEntityContainer
    {
        private static IServiceCollection _serviceCollection;
        private static ServiceProvider _serviceProvider;

        static QtiEntityContainer()
        {
            GetServiceCollectionSingleton();
        }

        private static IServiceCollection GetServiceCollectionSingleton()
        {
            if (_serviceCollection == null)
            {
                _serviceCollection = ServiceCollectionUtils
                    .RegisterRepositoryFromAssembly(alias: "OSEAGE_QTI", smartSqlMapConfig: "SmartSqlConfig/MSSQL/SmartSqlMapConfig-QTI.xml", assemblyString: "OSeage.QTI.Repository")
                    .RegisterService(namespaceString: "OSeage.QTI.Service");
            }
            if (_serviceProvider == null)
            {
                _serviceProvider = _serviceCollection.BuildServiceProvider();
            }
            return _serviceCollection;
        }

        /// <summary>
        /// 获取动态注入的对象
        /// </summary>
        public static T GetGenerateTypeObject<T>()
        {
            var generateTypeObject = _serviceProvider.GetRequiredService<T>();
            return generateTypeObject;
        }

        public static object GetGenerateTypeObject(Type type)
        {
            var generateTypeObject = _serviceProvider.GetRequiredService(type);
            return generateTypeObject;
        }
    }
}
