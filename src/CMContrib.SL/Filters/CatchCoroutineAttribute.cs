using System;
using System.Collections.Generic;
using Caliburn.Micro.Contrib.Decorators;

namespace Caliburn.Micro.Contrib.Filters
{
    /// <summary>
    ///   Catches every Exception during the execution of the coroutine and executes a rescue method
    /// </summary>
    public class CatchCoroutineAttribute : DecorateCoroutineAttribute
    {
        public string MethodName { get; set; }

        public override IEnumerable<IResult> Decorate(IEnumerable<IResult> coroutine, ActionExecutionContext context)
        {
            var targetType = context.Target.GetType();

            Func<Exception, IEnumerable<IResult>> handler = CreateHandler(context, targetType);

            var sequentialResult = new SequentialResult(coroutine.GetEnumerator());

            yield return new CatchResultDecorator(sequentialResult, handler);
        }

        private Func<Exception, IEnumerable<IResult>> CreateHandler(ActionExecutionContext context, Type targetType)
        {
            Func<Exception, IEnumerable<IResult>> handler = null;

            var method = targetType.GetMethod(MethodName, new[] {typeof (Exception)});
            if (method != null)
            {
                handler = ex =>
                          {
                              var result = method.Invoke(context.Target, new object[] { ex });
                              if (result is IResult) return new[] { result as IResult };
                              if (result is IEnumerable<IResult>) return result as IEnumerable<IResult>;

                              return new IResult[0];
                          };
            }
            else
            {
                method = targetType.GetMethod(MethodName, Type.EmptyTypes);

                if (method != null)
                {
                    handler = ex =>
                              {
                                  var result = method.Invoke(context.Target, new object[0]);
                                  if (result is IResult) return new[] { result as IResult };
                                  if (result is IEnumerable<IResult>) return result as IEnumerable<IResult>;

                                  return new IResult[0];
                              };
                }
                else
                    throw new Exception(string.Format("Could not find method {0} on type {1}",
                                                      MethodName,
                                                      targetType.Name));
            }
            return handler;
        }
    }
}