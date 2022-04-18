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
using WpfApp8.Helper;
using WpfApp8.Model;
using System.Collections.ObjectModel;

namespace WpfApp8.View
{
    public partial class WindowOrder : Window
    {
        OrderViewModel vmOrder;
        OrderTypeViewModel vmType;
        OrderVerietyViewModel vmVeriety;
        CurrencyViewModel vmCurrency;
        List<OrderType> types;
        List<OrderVeriety> verieties;
        List<Currency> currencies;
        ObservableCollection<OrderDPO> ordersDPO;

        public WindowOrder()
        {
            InitializeComponent();

            vmOrder = new OrderViewModel();
            vmType = new OrderTypeViewModel();
            vmVeriety = new OrderVerietyViewModel();
            vmCurrency = new CurrencyViewModel();
            types = vmType.ListType.ToList();
            verieties = vmVeriety.ListVeriety.ToList();
            currencies = vmCurrency.ListCurrency.ToList();

            ordersDPO = new ObservableCollection<OrderDPO>();
            foreach (var order in vmOrder.ListOrder)
            {
                OrderDPO p = new OrderDPO();
                p = p.CopyFromOrder(order);
                ordersDPO.Add(p);
            }
            lvOrder.ItemsSource = ordersDPO;
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            WindowNewOrder wnOrder = new WindowNewOrder
            {
                Title = "Новое поручение",
                Owner = this
            };
            int maxIdAddress = vmOrder.MaxId() + 1;
            OrderDPO ord = new OrderDPO
            {
                ID = maxIdAddress,
                Data = DateTime.Now,
                Duration = DateTime.Now.AddDays(30)
            };
            wnOrder.DataContext = ord;
            wnOrder.CbType.ItemsSource = types;
            wnOrder.CbVeriety.ItemsSource = verieties;
            wnOrder.CbCurrency.ItemsSource = currencies;
            if (wnOrder.ShowDialog() == true)
            {
                OrderType r = (OrderType)wnOrder.CbType.SelectedValue;
                ord.OrderType = r.Type;
                OrderVeriety p = (OrderVeriety)wnOrder.CbVeriety.SelectedValue;
                ord.OrderVeriety = p.Veriety;
                Currency c = (Currency)wnOrder.CbCurrency.SelectedValue;
                ord.Currency = c.CurrencyShort;
                ordersDPO.Add(ord);
                Order a = new Order();
                a = a.CopyFromOrderDPO(ord);
                vmOrder.ListOrder.Add(a);
            }
        }

        private void btnEdit_Click(object sender, RoutedEventArgs e)
        {
            WindowNewOrder wnOrder = new WindowNewOrder
            {
                Title = "Редактирование данных",
                Owner = this
            };
            OrderDPO ordDPO = (OrderDPO)lvOrder.SelectedValue;
            OrderDPO tempPerDPO;
            if (ordDPO != null)
            {
                tempPerDPO = ordDPO.ShallowCopy();
                wnOrder.DataContext = tempPerDPO;
                wnOrder.CbType.ItemsSource = types;
                wnOrder.CbVeriety.ItemsSource = verieties;
                wnOrder.CbCurrency.ItemsSource = currencies;
                wnOrder.CbType.Text = tempPerDPO.OrderType;
                wnOrder.CbVeriety.Text = tempPerDPO.OrderVeriety;
                wnOrder.CbCurrency.Text = tempPerDPO.Currency;
                if (wnOrder.ShowDialog() == true)
                {
                    OrderType r = (OrderType)wnOrder.CbType.SelectedValue;
                    ordDPO.OrderType = r.Type;
                    OrderVeriety p = (OrderVeriety)wnOrder.CbVeriety.SelectedValue;
                    ordDPO.OrderVeriety = p.Veriety;
                    Currency c = (Currency)wnOrder.CbCurrency.SelectedValue;
                    ordDPO.Currency = c.CurrencyShort;
                    ordDPO.Number = tempPerDPO.Number;
                    ordDPO.Tiker = tempPerDPO.Tiker;
                    ordDPO.Count = tempPerDPO.Count;
                    ordDPO.Data = tempPerDPO.Data;
                    ordDPO.Duration = tempPerDPO.Duration;
                    lvOrder.ItemsSource = null;
                    lvOrder.ItemsSource = ordersDPO;
                    FindOrder finder = new FindOrder(ordDPO.ID);
                    List<Order> listOrder = vmOrder.ListOrder.ToList();
                    Order a = listOrder.Find(new Predicate<Order>(finder.OrderPredicate));
                    a = a.CopyFromOrderDPO(ordDPO);
                }
            }
            else
            {
                MessageBox.Show("Необходимо выбрать поручение для редактированния",
                "Предупреждение", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }

        private void btnDelete_Click(object sender, RoutedEventArgs e)
        {
            OrderDPO order = (OrderDPO)lvOrder.SelectedItem;
            if (order != null)
            {
                MessageBoxResult result = MessageBox.Show("Удалить данные по поручению:\n" + order.ID, "Предупреждение", MessageBoxButton.OKCancel, MessageBoxImage.Warning);
                if (result == MessageBoxResult.OK)
                {
                    ordersDPO.Remove(order);
                    Order ord = new Order();
                    ord = ord.CopyFromOrderDPO(order);
                    vmOrder.ListOrder.Remove(ord);
                }
            }
            else
            {
                MessageBox.Show("Необходимо выбрать данные по поручению для удаления",
                "Предупреждение", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }
    }
}
