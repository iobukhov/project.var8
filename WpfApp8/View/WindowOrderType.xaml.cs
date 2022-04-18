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
    public partial class WindowOrderType : Window
    {
        OrderTypeViewModel vmType;
        public WindowOrderType()
        {
            InitializeComponent();

            vmType = new OrderTypeViewModel();
            lvType.ItemsSource = vmType.ListType;
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            WindowNewOrderType wnType = new WindowNewOrderType
            {
                Title = "Новый тип сделки",
                Owner = this
            };
            int maxIdType = vmType.MaxId() + 1;
            OrderType orderType = new OrderType
            {
                ID = maxIdType
            };
            wnType.DataContext = orderType;
            if (wnType.ShowDialog() == true)
            {
                vmType.ListType.Add(orderType);
            }
        }

        private void btnEdit_Click(object sender, RoutedEventArgs e)
        {
            WindowNewOrderType wnType = new WindowNewOrderType
            {
                Title = "Редактирование типа сделки",
                Owner = this
            };
            OrderType orderType = lvType.SelectedItem as OrderType;
            if (orderType != null)
            {
                OrderType tempType = orderType.ShallowCopy();
                wnType.DataContext = tempType;
                if (wnType.ShowDialog() == true)
                {
                    orderType.Type = tempType.Type;
                    lvType.ItemsSource = null;
                    lvType.ItemsSource = vmType.ListType;
                }
            }
            else
            {
                MessageBox.Show("Необходимо выбрать тип сделки для редактированния",
                "Предупреждение", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }

        private void btnDelete_Click(object sender, RoutedEventArgs e)
        {
            OrderType orderType = (OrderType)lvType.SelectedItem;
            if (orderType != null)
            {
                MessageBoxResult result = MessageBox.Show("Удалить данные по типу сделки: " +
                orderType.Type, "Предупреждение", MessageBoxButton.OKCancel,
                MessageBoxImage.Warning);
                if (result == MessageBoxResult.OK)
                {
                    vmType.ListType.Remove(orderType);
                }
            }
            else
            {
                MessageBox.Show("Необходимо выбрать тип сделки для удаления",
                "Предупреждение", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }
    }
}
