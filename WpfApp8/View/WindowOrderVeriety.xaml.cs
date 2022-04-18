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
using System.Windows.Shapes;
using WpfApp8.ViewModel;
using WpfApp8.Model;

namespace WpfApp8.View
{
    public partial class WindowOrderVeriety : Window
    {
        OrderVerietyViewModel vmVeriety;
        public WindowOrderVeriety()
        {
            InitializeComponent();

            vmVeriety = new OrderVerietyViewModel();
            lvType.ItemsSource = vmVeriety.ListVeriety;
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            WindowNewOrderVeriety wnVeriety = new WindowNewOrderVeriety
            {
                Title = "Новый вид сделки",
                Owner = this
            };
            int maxIdVeriety = vmVeriety.MaxId() + 1;
            OrderVeriety orderVeriety = new OrderVeriety
            {
                ID = maxIdVeriety
            };
            wnVeriety.DataContext = orderVeriety;
            if (wnVeriety.ShowDialog() == true)
            {
                vmVeriety.ListVeriety.Add(orderVeriety);
            }
        }

        private void btnEdit_Click(object sender, RoutedEventArgs e)
        {
            WindowNewOrderVeriety wnVeriety = new WindowNewOrderVeriety
            {
                Title = "Редактирование вида сделки",
                Owner = this
            };
            OrderVeriety orderVeriety = lvType.SelectedItem as OrderVeriety;
            if (orderVeriety != null)
            {
                OrderVeriety tempType = orderVeriety.ShallowCopy();
                wnVeriety.DataContext = tempType;
                if (wnVeriety.ShowDialog() == true)
                {
                    orderVeriety.Veriety = tempType.Veriety;
                    lvType.ItemsSource = null;
                    lvType.ItemsSource = vmVeriety.ListVeriety;
                }
            }
            else
            {
                MessageBox.Show("Необходимо выбрать вид сделки для редактированния",
                "Предупреждение", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }

        private void btnDelete_Click(object sender, RoutedEventArgs e)
        {
            OrderVeriety orderVeriety = (OrderVeriety)lvType.SelectedItem;
            if (orderVeriety != null)
            {
                MessageBoxResult result = MessageBox.Show("Удалить данные по виду сделки: " +
                orderVeriety.Veriety, "Предупреждение", MessageBoxButton.OKCancel,
                MessageBoxImage.Warning);
                if (result == MessageBoxResult.OK)
                {
                    vmVeriety.ListVeriety.Remove(orderVeriety);
                }
            }
            else
            {
                MessageBox.Show("Необходимо выбрать вид сделки для удаления",
                "Предупреждение", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }
    }
}
