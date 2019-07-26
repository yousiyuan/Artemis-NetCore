using AspectInjector.Broker;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace OSeage.QTI.BusinessFacade.Core
{
    [AttributeUsage(AttributeTargets.Constructor)]
    [Aspect(Scope.PerInstance)]
    [Injection(typeof(QtiServiceAttribute))]
    public class QtiServiceAttribute : Attribute
    {
        [Advice(Kind.Around, Targets = Target.Constructor)]
        public object ConstructorAroundAdvice(
            [Argument(Source.Name)] string name,
            [Argument(Source.Instance)] object instance,
            [Argument(Source.Arguments)] object[] arguments,
            [Argument(Source.Target)] Func<object[], object> method,
            [Argument(Source.ReturnType)] Type retType)
        {
            var type = instance.GetType();
            var constructorList = new List<ConstructorInfo>(type.GetConstructors());
            var constructorMethod = constructorList.Where(constructor => constructor.GetCustomAttribute<QtiServiceAttribute>() != null).FirstOrDefault();

            if (constructorMethod == null)
                throw new ArgumentNullException("QtiServiceAttribute", "缺少[QtiService]修饰的构造器");
            
            var paramList = new List<object>();
            foreach (var param in constructorMethod.GetParameters())
            {
                var generateTypeObject = QtiEntityContainer.GetGenerateTypeObject(param.ParameterType);
                paramList.Add(generateTypeObject);
            }
            var result = method(paramList.ToArray());
            //var generateObject = Activator.CreateInstance(type, paramList.ToArray());
            return result;
            //return generateObject;
        }
    }
}
