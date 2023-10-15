using System.Windows;
using System.Windows.Input;

namespace login
{
    /// <summary>
    /// Interação lógica para MainWindow.xam
    /// </summary>
    public partial class MainWindow : Window
    {
        private void Btnminimiz_Click(object sender, MouseButtonEventArgs e)
        {
            WindowState = WindowState.Minimized;
        }
        private void Btnclose_Click(object sender, MouseButtonEventArgs e)
        {
            Application.Current.Shutdown();
        }
        private void Btnlogin_Click(object sender, MouseButtonEventArgs e)
        {

        }
    }
}
