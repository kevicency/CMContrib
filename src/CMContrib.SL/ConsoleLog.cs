using System;

namespace Caliburn.Micro.Contrib
{
    /// <summary>
    ///   A simple log thats logs everything to the console
    /// </summary>
    public class ConsoleLog : ILog
    {
        private readonly Type _type;

        public ConsoleLog(Type type)
        {
            _type = type;
        }

        #region ILog Members

        public void Info(string format, params object[] args)
        {
            Console.WriteLine("[{1}] INFO: {0}", String.Format(format, args), _type.Name);
        }

        public void Warn(string format, params object[] args)
        {
            Console.WriteLine("[{1}] WARN: {0}", String.Format(format, args), _type.Name);
        }

        public void Error(Exception exception)
        {
            Console.WriteLine("[{1}] Error: {0}", exception, _type.Name);
        }

        #endregion
    }
}