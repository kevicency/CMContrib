namespace Caliburn.Micro.Contrib.Dialogs
{
    public interface IBindableResponse
    {
        object Response { get; }
        bool IsDefault { get; set; }
        bool IsCancel { get; set; }
    }

    public class BindableResponse<TResponse> : IBindableResponse
    {
        public TResponse Response { get; set; }

        #region IBindableResponse Members

        object IBindableResponse.Response
        {
            get { return Response; }
        }

        public bool IsDefault { get; set; }
        public bool IsCancel { get; set; }

        #endregion
    }
}