using System.ComponentModel.Composition;
using System.Windows;
using System.Windows.Input;
using Caliburn.Micro.Contrib.Dialogs;
using WPF.Themes;

namespace Caliburn.Micro.Contrib.Demo
{
    [Export]
    public partial class ShellView : Window, IBusyIndicator
    {
        public ShellView()
        {
            InitializeComponent();
        }

        public void Busy(string message)
        {
            BusyIndicator.BusyContent = message;
            BusyIndicator.IsBusy = true;
        }

        public void Idle()
        {
            BusyIndicator.IsBusy = false;
        }

        private void DragMoveWindow(object sender, MouseButtonEventArgs e)
        {
            if (e.RightButton != MouseButtonState.Pressed && e.MiddleButton != MouseButtonState.Pressed && e.LeftButton == MouseButtonState.Pressed)
            {
                if (WindowState == WindowState.Maximized)
                {
                    // Calcualting correct left coordinate for multi-screen system.
                    double mouseX = PointToScreen(Mouse.GetPosition(this)).X;
                    double width = RestoreBounds.Width;
                    double left = mouseX - width / 2;

                    // Aligning window's position to fit the screen.
                    double virtualScreenWidth = SystemParameters.VirtualScreenWidth;
                    left = left < 0 ? 0 : left;
                    left = left + width > virtualScreenWidth ? virtualScreenWidth - width : left;

                    Top = 0;
                    Left = left;

                    // Restore window to normal state.
                    WindowState = WindowState.Normal;

                }

                DragMove();
            }
            if (e.ClickCount != 2)
                return;

            WindowState = WindowState == WindowState.Maximized ? WindowState.Normal : WindowState.Maximized;
        }

        private void ButtonMinimiseOnClick(object sender, RoutedEventArgs e)
        {
            WindowState = WindowState.Minimized;
        }

        private void ButtonMaxRestoreOnClick(object sender, RoutedEventArgs e)
        {
            WindowState = WindowState == WindowState.Maximized ? WindowState.Normal : WindowState.Maximized;
        }


        protected override void OnStateChanged(System.EventArgs e)
        {
            RefreshMaximiseIconState();
            base.OnStateChanged(e);
        }

        private void RefreshMaximiseIconState()
        {
            if (WindowState == WindowState.Normal)
            {
                maxRestore.Content = "1";
                maxRestore.SetResourceReference(ToolTipProperty, "WindowCommandsMaximiseToolTip");
            }
            else
            {
                maxRestore.Content = "2";
                maxRestore.SetResourceReference(ToolTipProperty, "WindowCommandsRestoreToolTip");
            }
        }

        private void WindowDragOver(object sender, DragEventArgs e)
        {
            bool isFileDrop = e.Data.GetDataPresent(DataFormats.FileDrop);
            e.Effects = isFileDrop ? DragDropEffects.Move : DragDropEffects.None;
            e.Handled = true;
        }
    }
}