using Caliburn.Micro.Contrib.Dialogs;
using Caliburn.Micro.Contrib.Results;

namespace Caliburn.Micro.Contrib
{
    /// <summary>
    ///   Extension Methods for <see cref = "Dialog" />s
    /// </summary>
    public static class DialogExtensions
    {
        /// <summary>
        ///   Creates a result which shows the dialog to the user
        /// </summary>
        /// <typeparam name = "TResponse"></typeparam>
        /// <param name = "dialog"></param>
        /// <returns></returns>
        public static DialogResult<TResponse> AsResult<TResponse>(this Dialog<TResponse> dialog)
        {
            return new DialogResult<TResponse>(dialog);
        }
    }
}