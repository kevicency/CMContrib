using System.Linq;
using Caliburn.Micro;
using Caliburn.Micro.Contrib.Dialogs;
using NUnit.Framework;

namespace CMContrib.Test.Dialog
{
    [TestFixture]
    public class DialogViewModel_Fixture
    {
        private string[] _responses;
        private Dialog<string> _userDialog;

        [SetUp]
        public void SetUp()
        {
            _responses = Enumerable.Range(1, 3)
                .Select(x => "Response" + x)
                .ToArray();

            _userDialog = new Dialog<string>(string.Empty, string.Empty, _responses);
        }

        [Test]
        public void SettingDialog_CreatesBindableResponses()
        {
            var sut = new DialogViewModel<string>();

            sut.Dialog = _userDialog;

            Assert.AreEqual(3, sut.Responses.Count);
            for (int i = 0; i < _responses.Length; i++)
            {
                Assert.AreEqual(_responses[i], sut.Responses[i].Response);
            }
        }

        [Test]
        public void SettingDialog_FirstResponseIsDefault()
        {
            var sut = new DialogViewModel<string>();

            sut.Dialog = _userDialog;

            Assert.IsTrue(sut.Responses[0].IsDefault);
        }

        [Test]
        public void SettingDialog_LastResponseIsCancel()
        {
            var sut = new DialogViewModel<string>();

            sut.Dialog = _userDialog;

            Assert.IsTrue(sut.Responses[sut.Responses.Count-1].IsCancel);
        }

        [Test]
        public void ClosingBeforeResponding_SetsResponseToCancelResponse()
        {
            var sut = new DialogViewModel<string>();
            (sut as IActivate).Activate();
            sut.Dialog = _userDialog;
            foreach (var bindableResponse in sut.Responses)
            {
                bindableResponse.IsCancel = false;
            }
            var cancelResponse = sut.Responses[1];
            cancelResponse.IsCancel = true;

            (sut as IDeactivate).Deactivate(true);

            Assert.AreEqual(cancelResponse.Response, sut.Dialog.GivenResponse);
        }


        [Test]
        public void ClosingBeforeResponding_SetsResponseToDefaultResponse_WhenNoCancelResponseExists()
        {
            var sut = new DialogViewModel<string>();
            (sut as IActivate).Activate();
            sut.Dialog = _userDialog;
            foreach (var bindableResponse in sut.Responses)
            {
                bindableResponse.IsCancel = false;
                bindableResponse.IsDefault = false;
            }
            var defaultResponse = sut.Responses[1];
            defaultResponse.IsDefault = true;

            (sut as IDeactivate).Deactivate(true);

            Assert.AreEqual(defaultResponse.Response, sut.Dialog.GivenResponse);
        }

        [Test]
        public void ClosingBeforeResponding_SetsResponseToFirstResponse_WhenNoCancelResponseExists_AndNoDefautlResponseExists()
        {
            var sut = new DialogViewModel<string>();
            (sut as IActivate).Activate();
            sut.Dialog = _userDialog;
            foreach (var bindableResponse in sut.Responses)
            {
                bindableResponse.IsCancel = false;
                bindableResponse.IsDefault = false;
            }
            var firstResponse = sut.Responses.First();

            (sut as IDeactivate).Deactivate(true);

            Assert.AreEqual(firstResponse.Response, sut.Dialog.GivenResponse);
        }

        [Test]
        public void Respond_SetsTheResponseOnTheDialog()
        {
            var sut = new DialogViewModel<string>();
            sut.Dialog = _userDialog;

            sut.Respond(sut.Responses[0]);

            Assert.AreEqual(_responses[0], sut.Dialog.GivenResponse);
        }
    }
}
