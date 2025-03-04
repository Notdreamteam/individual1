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
    /// Логика взаимодействия для Task1Page.xaml
    /// </summary>
    public partial class Task1Page : Page
    {
        public Task1Page()
        {
            InitializeComponent();
        }

        private void BtnTask1_Click(object sender, RoutedEventArgs e)
        {

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

        private void BtnGetPrice_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(TbPrice.Text))
            {
                MessageBox.Show("Ошибка ввода данных",
                                "Задание №1",
                                MessageBoxButton.OK,
                                MessageBoxImage.Error);
            }
            else
            {
                int price = Convert.ToInt32(TbPrice.Text);
                Task1Class task1 = new Task1Class();

                MessageBox.Show($"Стоимость покупки - {task1.FindPrice(price)}",
                                "Задание №1",
                                MessageBoxButton.OK,
                                MessageBoxImage.Information);
                ClearFields();
            }
        }

        private void ClearFields()
        {
            TbPrice.Clear();
        }
    }
}
