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
    public partial class WindowCurrency : Window
    {
        CurrencyViewModel vmCurrency;

        public WindowCurrency()
        {
            InitializeComponent();

            vmCurrency = new CurrencyViewModel();
            lvCurrency.ItemsSource = vmCurrency.ListCurrency;
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            WindowNewCurrency wnCurrency = new WindowNewCurrency
            {
                Title = "Новая валюта",
                Owner = this
            };
            int maxIdCurrency = vmCurrency.MaxId() + 1;
            Currency currency = new Currency
            {
                ID = maxIdCurrency
            };
            wnCurrency.DataContext = currency;
            if (wnCurrency.ShowDialog() == true)
            {
                vmCurrency.ListCurrency.Add(currency);
            }
        }

        private void btnEdit_Click(object sender, RoutedEventArgs e)
        {
            WindowNewCurrency wnCurrency = new WindowNewCurrency
            {
                Title = "Редактирование валюты",
                Owner = this
            };
            Currency currency = lvCurrency.SelectedItem as Currency;
            if (currency != null)
            {
                Currency tempCurrency = currency.ShallowCopy();
                wnCurrency.DataContext = tempCurrency;
                if (wnCurrency.ShowDialog() == true)
                {
                    currency.CurrencyFull = tempCurrency.CurrencyFull;
                    currency.CurrencyShort = tempCurrency.CurrencyShort;
                    lvCurrency.ItemsSource = null;
                    lvCurrency.ItemsSource = vmCurrency.ListCurrency;
                }
            }
            else
            {
                MessageBox.Show("Необходимо выбрать валюту для редактирования",
                "Предупреждение", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }

        private void btnDelete_Click(object sender, RoutedEventArgs e)
        {
            Currency currency = (Currency)lvCurrency.SelectedItem;
            if (currency != null)
            {
                MessageBoxResult result = MessageBox.Show("Удалить данные по валюте: " +
                currency.CurrencyFull, "Предупреждение", MessageBoxButton.OKCancel,
                MessageBoxImage.Warning);
                if (result == MessageBoxResult.OK)
                {
                    vmCurrency.ListCurrency.Remove(currency);
                }
            }
            else
            {
                MessageBox.Show("Необходимо выбрать валюту для удаления",
                "Предупреждение", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }
    }
}
