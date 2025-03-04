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
    /// Логика взаимодействия для Task2Page.xaml
    /// </summary>
    public partial class Task2Page : Page
    {
        public Task2Page()
        {
            InitializeComponent();
        }

        private void BtnTask1_Click(object sender, RoutedEventArgs e)
        {
            ConnectionCore.CoreFrame?.Navigate(new Task1Page());
        }

        private void BtnTask2_Click(object sender, RoutedEventArgs e)
        {

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

        private void BtnGetRate_Click(object sender, RoutedEventArgs e)
        {
            if(string.IsNullOrEmpty(TbWD.Text) ||
               string.IsNullOrEmpty(TbWD.Text))
            {
                MessageBox.Show("Ошибка ввода данных",
                                "Задание №2",
                                MessageBoxButton.OK,
                                MessageBoxImage.Error);
            }
            else
            {
                double weekend, weekdays;

                weekend = Convert.ToDouble(TbW.Text);
                weekdays = Convert.ToDouble(TbWD.Text);

                Task2Class[] costs =
                {
                    new Task2Class(50, 0.1),
                    new Task2Class(45, 0.08),
                    new Task2Class(55, 0.12)
                };

                TbFirst.Text = costs[0].CostOfCall(weekend, weekdays);
                TbSecond.Text = costs[1].CostOfCall(weekend, weekdays);
                TbThird.Text = costs[2].CostOfCall(weekend, weekdays);

                SpRate.Visibility = Visibility.Visible;

                ClearTB();
            }
        }

        private void ClearTB()
        {
            TbW.Text = string.Empty;
            TbWD.Text = string.Empty;
        }
    }
}
