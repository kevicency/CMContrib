using System;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;

namespace Caliburn.Micro.Contrib.Interaction
{
    public interface IBusyIndicator
    {
        void Show(string message);
        void Hide();
    }
}
