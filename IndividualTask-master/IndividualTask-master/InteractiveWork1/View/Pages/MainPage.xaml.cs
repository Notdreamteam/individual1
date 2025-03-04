using System.Windows;
using System.Windows.Controls;
using InteractiveWork1.Core;

namespace InteractiveWork1.View.Pages
{
    /// <summary>
    /// Логика взаимодействия для MainPage.xaml
    /// </summary>
    public partial class MainPage : Page
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void BtnTasks_Click(object sender, RoutedEventArgs e)
        {
            ConnectionCore.CoreFrame?.Navigate(new TaskPage());
        }
    }
}
