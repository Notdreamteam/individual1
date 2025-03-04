using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using InteractiveWork1.Core;
using InteractiveWork1.Core.Tasks;

namespace InteractiveWork1.View.Pages.PageTask
{
    /// <summary>
    /// Логика взаимодействия для Task4Page.xaml
    /// </summary>
    public partial class Task4Page : Page
    {
        public Task4Page()
        {
            InitializeComponent();
        }

        private void BtnTask1_Click(object sender, RoutedEventArgs e)
        {
            ConnectionCore.CoreFrame?.Navigate(new Task1Page());
        }

        private void BtnTask2_Click(object sender, RoutedEventArgs e)
        {
            ConnectionCore.CoreFrame?.Navigate(new Task2Page());
        }

        private void BtnTask3_Click(object sender, RoutedEventArgs e)
        {
            ConnectionCore.CoreFrame?.Navigate(new Task3Page());
        }

        private void BtnTask4_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BtnTask5_Click(object sender, RoutedEventArgs e)
        {
            ConnectionCore.CoreFrame?.Navigate(new Task5Page());
        }

        private void BtnLogout_Click(object sender, RoutedEventArgs e)
        {
            if (MessageBox.Show("Вы действительно хотите выйти?",
                   "Системное сообщение",
                   MessageBoxButton.YesNo,
                   MessageBoxImage.Question) == MessageBoxResult.Yes)
            {
                App.Current.Shutdown();
            }
        }

        private void BtnAns_Click(object sender, RoutedEventArgs e)
        {
            if(string.IsNullOrEmpty(TbFirstNumber.Text) ||
               string.IsNullOrEmpty(TbSecondNumber.Text))
            {
                MessageBox.Show("Ошибка ввода данных",
                                "Задание №4",
                                MessageBoxButton.OK,
                                MessageBoxImage.Error);
            }
            else
            {
                double a, b;

                a = Convert.ToDouble(TbFirstNumber.Text);
                b = Convert.ToDouble(TbSecondNumber.Text);

                Task4Class sqare = new Task4Class(a, b);

                MessageBox.Show(sqare.Print(),
                                "Задание №4",
                                MessageBoxButton.OK,
                                MessageBoxImage.Information);
            }
            Clear();
        }

        private void Clear()
        {
            TbFirstNumber.Text = string.Empty;
            TbSecondNumber.Text = string.Empty;
        }
    }
}
