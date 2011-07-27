using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace Caliburn.Micro.Contrib.Filters
{
    /// <summary>
    ///   Catches every error during the execution of the coroutine and executes a rescue method
    /// </summary>
    [AttributeUsage(AttributeTargets.Method | AttributeTargets.Class)]
    public class RescueAttribute : DecorateCoroutineAttribute
    {
        public string MethodName { get; set; }

        public RescueAttribute()
        {
            MethodName = "Rescue";
        }

        public override IEnumerable<IResult> Decorate(IEnumerable<IResult> coroutine, ActionExecutionContext context)
        {
            var targetType = context.Target.GetType();

            Func<Exception, IEnumerable<IResult>> handler = CreateHandler(context, targetType);

            var sequentialResult = new SequentialResult(coroutine.GetEnumerator());

            yield return sequentialResult
                .Rescue().Execute(handler);
        }

        private Func<Exception, IEnumerable<IResult>> CreateHandler(ActionExecutionContext context, Type targetType)
        {
            Func<Exception, IEnumerable<IResult>> handler = null;
#if SILVERLIGHT
            // you may not invoke private methods in SL
            const BindingFlags bindingFlags = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static;
#elif WPF
            const BindingFlags bindingFlags = BindingFlags.NonPublic | BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static;
#endif

            var method = targetType.GetMethod(MethodName, bindingFlags, Type.DefaultBinder, new[] { typeof(Exception) }, null)
                ?? targetType.GetMethod(MethodName, bindingFlags);

            if (method == null)
                throw new Exception(string.Format("Could not find method {0} on type {1}",
                                                  MethodName,
                                                  targetType.Name));

            var obj = method.IsStatic ? null : context.Target;
            handler = ex =>
                      {
                          var param = method.GetParameters().Any() ? new object[] { ex } : new object[0];
                          object result = method.Invoke(obj, param);

                          if (result is IResult) return new[] { result as IResult };
                          if (result is IEnumerable<IResult>) return result as IEnumerable<IResult>;

                          return new IResult[0];
                      };

            return handler;
        }
    }
}