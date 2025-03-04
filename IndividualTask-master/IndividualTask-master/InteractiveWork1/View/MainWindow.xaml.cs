using System.Windows;
using InteractiveWork1.Core;
using InteractiveWork1.View.Pages;

namespace InteractiveWork1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            ConnectionCore.CoreFrame = MainFrame;

            MainFrame.Navigate(new MainPage());
        }

        private void Window_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            if(e.ClickCount == 2)
            {
                Application.Current.Shutdown();
            }
        }
    }
}