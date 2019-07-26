using AspectInjector.Broker;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace Oseage.Common.Tools.AspectNet
{
    /// <summary>
    /// 切面
    /// </summary>
    [Aspect(Scope.PerInstance)]
    [Injection(typeof(ObjectAspectAttribute))]
    public class ObjectAspectAttribute : Attribute
    {
        /// <summary>
        /// 构造器 前置通知
        /// </summary>
        [Advice(Kind.Before, Targets = Target.Constructor)]
        public void ConstructorBeforeAdvice()
        {
            Console.WriteLine("构造器 前置通知");
        }

        /// <summary>
        /// 构造器 后置通知
        /// </summary>
        [Advice(Kind.After, Targets = Target.Constructor)]
        public void ConstructorAfterAdvice()
        {
            Console.WriteLine("构造器 后置通知");
        }

        /// <summary>
        /// 构造器 环绕通知
        /// </summary>
        [Advice(Kind.Around, Targets = Target.Constructor)]
        public object ConstructorAroundAdvice()
        {
            Console.WriteLine("构造器 环绕通知");
            return null;
        }

        /// <summary>
        /// 函数成员 前置通知
        /// </summary>
        [Advice(Kind.Before, Targets = Target.Method)]
        public void FunctionBeforeAdvice()
        {
            Console.WriteLine("函数成员 前置通知");
        }

        /// <summary>
        /// 函数成员 后置通知
        /// </summary>
        [Advice(Kind.After, Targets = Target.Method)]
        public void FunctionAfterAdvice()
        {
            Console.WriteLine("函数成员 后置通知");
        }

        /// <summary>
        /// 函数成员 环绕通知
        /// </summary>
        [Advice(Kind.Around, Targets = Target.Method)]
        public object FunctionAroundAdvice(
            [Argument(Source.Name)] string name,
            [Argument(Source.Arguments)] object[] arguments,
            [Argument(Source.Target)] Func<object[], object> method,
            [Argument(Source.ReturnType)] Type retType)
        {
            Console.WriteLine("函数成员 环绕通知");
            Console.WriteLine($"Executing method {name}");
            var sw = Stopwatch.StartNew();

            var result = method(arguments);

            sw.Stop();
            Console.WriteLine($"Executed method {name} in {sw.ElapsedMilliseconds} ms");

            return result;
        }

        /// <summary>
        /// 属性成员 Getter访问器 前置通知
        /// </summary>
        [Advice(Kind.Before, Targets = Target.Public | Target.Getter)]
        public void PropertyGetterBeforeAdvice()
        {
            Console.WriteLine("属性成员 Getter访问器 前置通知");
        }

        /// <summary>
        /// 属性成员 Getter访问器 后置通知
        /// </summary>
        [Advice(Kind.After, Targets = Target.Public | Target.Getter)]
        public void PropertyGetterAfterAdvice()
        {
            Console.WriteLine("属性成员 Getter访问器 后置通知");
        }

        /// <summary>
        /// 属性成员 Getter访问器 环绕通知
        /// </summary>
        [Advice(Kind.Around, Targets = Target.Public | Target.Getter)]
        public object PropertyGetterAroundAdvice()
        {
            Console.WriteLine("属性成员 Getter访问器 环绕通知");

            return null;
        }

        /// <summary>
        /// 属性成员 Setter设置器 前置通知
        /// </summary>
        [Advice(Kind.Before, Targets = Target.Public | Target.Setter)]
        public void PropertySetterBeforeAdvice()
        {
            Console.WriteLine("属性成员 Setter设置器 前置通知");
        }

        /// <summary>
        /// 属性成员 Setter设置器 后置通知
        /// </summary>
        [Advice(Kind.After, Targets = Target.Public | Target.Setter)]
        public void PropertySetterAfterAdvice(
            [Argument(Source.Instance)] object source,
            [Argument(Source.Name)] string propName,
            [Argument(Source.Triggers)] Attribute[] injections)
        {
            Console.WriteLine("属性成员 Setter设置器 后置通知");
        }

        /// <summary>
        /// 属性成员 Setter设置器 环绕通知
        /// </summary>
        [Advice(Kind.Around, Targets = Target.Public | Target.Setter)]
        public object PropertySetterAroundAdvice(
            [Argument(Source.Instance)] object source,
            [Argument(Source.Name)]  string proName,
            [Argument(Source.Triggers)] Attribute[] injections
            )
        {
            Console.WriteLine("属性成员 Setter设置器 环绕通知");
            return source;
        }
    }
}
