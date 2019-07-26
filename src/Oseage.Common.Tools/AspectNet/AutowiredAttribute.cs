using AspectInjector.Broker;
using System;
using System.Collections.Generic;
using System.Text;

namespace Oseage.Common.Tools.AspectNet
{
    [AttributeUsage(AttributeTargets.Property | AttributeTargets.Field)]
    [Aspect(Scope.PerInstance)]
    [Injection(typeof(AutowiredAttribute))]
    public class AutowiredAttribute : Attribute
    {
        /// <summary>
        /// 属性成员 Getter访问器 环绕通知
        /// </summary>
        [Advice(Kind.Around, Targets = Target.Public | Target.Private | Target.Protected | Target.Getter)]
        public object PropertyGetterAroundAdvice(
            [Argument(Source.Name)] string name,
            [Argument(Source.Instance)] object instance,
            [Argument(Source.Arguments)] object[] arguments,
            [Argument(Source.Target)] Func<object[], object> method,
            [Argument(Source.ReturnType)] Type retType)
        {
            Console.WriteLine("属性成员 Getter访问器 环绕通知");

            return null;
        }
    }
}
