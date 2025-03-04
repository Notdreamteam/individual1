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
    /// Логика взаимодействия для Task5Page.xaml
    /// </summary>
    public partial class Task5Page : Page
    {
        public Task5Page()
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
            ConnectionCore.CoreFrame?.Navigate(new Task4Page());
        }

        private void BtnTask5_Click(object sender, RoutedEventArgs e)
        {

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
            if (string.IsNullOrEmpty(TbX.Text) ||
                string.IsNullOrEmpty(TbY.Text))
            {
                MessageBox.Show("Ошибка ввода данных",
                                "Задание №4",
                                MessageBoxButton.OK,
                                MessageBoxImage.Error);
            }
            else
            {
                double a, b;

                a = Convert.ToDouble(TbX.Text);
                b = Convert.ToDouble(TbY.Text);

                Task5Class coordinates = new Task5Class(a, b);

                MessageBox.Show(coordinates.Exp(),
                                "Задание №4",
                                MessageBoxButton.OK,
                                MessageBoxImage.Information);
            }
            Clear();
        }

        private void Clear()
        {
            TbX.Text = string.Empty;
            TbY.Text = string.Empty;
        }
    }
}
