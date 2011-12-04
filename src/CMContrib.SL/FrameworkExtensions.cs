using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Text.RegularExpressions;
using System.Windows;
using System.Windows.Markup;
using System.Xml;
using Caliburn.Micro.Contrib.Decorators;
using Caliburn.Micro.Contrib.Filters;
using Expression = System.Linq.Expressions.Expression;

namespace Caliburn.Micro.Contrib
{
    /// <summary>
    ///   Static class used to store Caliburn.Micro extensions.
    /// </summary>
    public static class FrameworkExtensions
    {
        /// <summary>
        ///   Static class used to store extensions related to the <see cref = "Caliburn.Micro.ActionMessage" />.
        /// </summary>
        public static class ActionMessage
        {
            private static readonly Action<ActionExecutionContext> BaseInvokeAction =
                Micro.ActionMessage.InvokeAction;

            internal static void InvokeAction(ActionExecutionContext context)
            {
                var decorators = context.GetFilters()
                    .OfType<IDecorateCoroutineFilter>()
                    .ToArray();

                // Use the default behaviour when no decorators are found
                if (!decorators.Any())
                {
                    BaseInvokeAction(context);
                    return;
                }
                
                var values = MessageBinder.DetermineParameters(context, context.Method.GetParameters());
                var returnValue = context.Method.Invoke(context.Target, values);

                IEnumerable<IResult> coroutine;
                if (returnValue is IResult)
                {
                    coroutine = new[] { returnValue as IResult };
                }
                else if (returnValue is IEnumerable<IResult>)
                {
                    coroutine = returnValue as IEnumerable<IResult>;
                }
                else return;

                coroutine = decorators.Aggregate(coroutine, (current, decorator) => decorator.Decorate(current, context));

                Coroutine.BeginExecute(coroutine.GetEnumerator(), context);
            }

            public static void EnableFilters(bool enable = true)
            {
                Micro.ActionMessage.InvokeAction = enable ? InvokeAction : BaseInvokeAction;
            }
        }

        #region Nested type: Message

        /// <summary>
        ///   Static class used to store extensions related to the <see cref = "Caliburn.Micro.Message" />.
        /// </summary>
        public static class Message
        {
            #region Nested type: Attach

            /// <summary>
            ///   Static class used to store extensions related to the <see cref = "Caliburn.Micro.Message.AttachProperty" />.
            /// </summary>
            public static class Attach
            {
                #region Static Fields

                /// <summary>
                ///   The additional namespaces to be used when trying to parse an action parameter defined into a markup extension.
                /// </summary>
                public static string XamlNamespaces =
                    "xmlns=\"http://schemas.microsoft.com/winfx/2006/xaml/presentation\" xmlns:x=\"http://schemas.microsoft.com/winfx/2006/xaml\" xmlns:cm=\"clr-namespace:Caliburn.Micro;assembly=Caliburn.Micro\"";

                /// <summary>
                ///   The default implementation of the <see cref = "Parser.CreateParameter" />.
                /// </summary>
                private static readonly Func<DependencyObject, string, Parameter> BaseCreateParameter =
                    Parser.CreateParameter;

                /// <summary>
                ///   The default implementation of the <see cref = "MessageBinder.EvaluateParameter" />.
                /// </summary>
                private static readonly Func<string, Type, ActionExecutionContext, object> BaseEvaluateParameter =
                    MessageBinder.EvaluateParameter;

                #endregion

                /// <summary>
                ///   The fragment used to generate a parameter.
                /// </summary>
                private const string PARAMETER_XAML_FRAGMENT = "<cm:Parameter {0} Value=\"{1}\"/>";

                /// <summary>
                ///   Loads the specified parameter using a <see cref = "XamlReader" />.
                /// </summary>
                /// <param name = "parameter">The parameter.</param>
                /// <returns>The deserialized object.</returns>
                private static object LoadXaml(string parameter)
                {
#if SILVERLIGHT
                    return XamlReader.Load(parameter);
#else
                    using (var input = new StringReader(parameter))
                    {
                        using (var reader = XmlReader.Create(input))
                            return XamlReader.Load(reader);
                    }
#endif
                }

                /// <summary>
                ///   Gets the parameter type.
                /// </summary>
                /// <param name = "value">The value.</param>
                /// <returns>The parameter type.</returns>
                private static Type GetParameterType(object value)
                {
                    return value != null ? value.GetType() : typeof(object);
                }

                /// <summary>
                ///   Evaluates the parameter.
                /// </summary>
                /// <param name = "expression">The expression.</param>
                /// <param name = "context">The context.</param>
                /// <param name = "resultType">Type of the result.</param>
                /// <returns>The evaluated parameter.</returns>
                private static object EvaluateParameter(string expression,
                                                        ActionExecutionContext context,
                                                        Type resultType)
                {
                    try
                    {
                        expression = Regex.Replace(expression, @"\$[a-zA-Z]+", x => x.ToString().ToLower());

                        var index = 0;
                        var parameters = new ParameterExpression[MessageBinder.SpecialValues.Count];
                        var values = new object[MessageBinder.SpecialValues.Count];
                        foreach (var pair in MessageBinder.SpecialValues)
                        {
                            var name = "@" + index;
                            expression = expression.Replace(pair.Key, name);
                            var value = pair.Value(context);
                            parameters[index] = Expression.Parameter(GetParameterType(value), name);
                            values[index] = value;
                            index++;
                        }

                        var exp = DynamicExpression.ParseLambda(parameters, resultType, expression);
                        return exp.Compile().DynamicInvoke(values);
                    }
                    catch (Exception exc)
                    {
                        LogManager.GetLog(typeof(MessageBinder)).Error(exc);
                        return null;
                    }
                }

                private static Parameter CreateParameter(DependencyObject o, string parameterText)
                {
                    if (Regex.IsMatch(parameterText, @"^[a-zA-Z]+\.[a-zA-Z]+(:?[a-zA-Z]+)$")
                        || Regex.IsMatch(parameterText, @"'[a-zA-Z]+'"))
                    {
                        return BaseCreateParameter(o, parameterText);
                    }

                    return new Parameter { Value = parameterText };
                }               

                /// <summary>
                ///   Allows action parameters to be specified using Xaml compact syntaxes and (optionally) parameters evaluation.
                /// </summary>
                /// <param name = "syntaxes">The extra syntaxes which should be allowed.</param>
                public static void AllowExtraSyntax(MessageSyntaxes syntaxes)
                {
                    MessageBinder.EvaluateParameter = BaseEvaluateParameter;
                    Parser.CreateParameter = BaseCreateParameter;

                    Func<DependencyObject, string, Parameter> createParameter =
                        syntaxes.HasFlag(MessageSyntaxes.SpecialValueProperty)
                            ? CreateParameter
                            : BaseCreateParameter;

                    if (syntaxes.HasFlag(MessageSyntaxes.XamlBinding))
                    {
                        Parser.CreateParameter =
                            (target, parameterText) =>
                            {
                                //Check if the parameter is defined as a markup...
                                if (parameterText.StartsWith("{") && parameterText.EndsWith("}"))
                                {
                                    try
                                    {
                                        parameterText = string.Format(PARAMETER_XAML_FRAGMENT,
                                                                      XamlNamespaces,
                                                                      parameterText);
                                        var parsed = LoadXaml(parameterText);

                                        return (Parameter)parsed;
                                    }
                                    catch (Exception exc)
                                    {
                                        LogManager.GetLog(typeof(Parser)).Error(exc);
                                    }
                                }

                                //Use the default implementation if the parameter is not identified as a binding...
                                return createParameter(target, parameterText);
                            };
                    }

                    if (syntaxes.HasFlag(MessageSyntaxes.SpecialValueProperty))
                    {
                        MessageBinder.EvaluateParameter = (text, parameterType, context) =>
                                                          {
                                                              var lookup = text.ToLower(CultureInfo.InvariantCulture);
                                                              Func<ActionExecutionContext, object> resolver;

                                                              if (MessageBinder.SpecialValues.TryGetValue(lookup,
                                                                                                          out resolver)) return resolver(context);

                                                              return
                                                                  MessageBinder.SpecialValues.Any(
                                                                      x => lookup.Contains(x.Key))
                                                                      ? EvaluateParameter(text, context, parameterType)
                                                                      : text;
                                                          };
                    }
                }
            }

            #endregion
        }

        #endregion
    }
}