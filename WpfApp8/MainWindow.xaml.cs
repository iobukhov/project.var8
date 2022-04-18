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
using WpfApp8.View;

namespace WpfApp8
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Order_OnClick(object sender, RoutedEventArgs e)
        {
            WindowOrder order = new WindowOrder();
            order.Show();
        }

        private void OrderType_OnClick(object sender, RoutedEventArgs e)
        {
            WindowOrderType orderType = new WindowOrderType();
            orderType.Show();
        }

        private void OrderVeriety_OnClick(object sender, RoutedEventArgs e)
        {
            WindowOrderVeriety orderVeriety = new WindowOrderVeriety();
            orderVeriety.Show();
        }

        private void Currency_OnClick(object sender, RoutedEventArgs e)
        {
            WindowCurrency currency = new WindowCurrency();
            currency.Show();
        }

        public static int IdOrder { get; set; }
        public static int IdOrderType { get; set; }
        public static int IdOrderVeriety { get; set; }
        public static int IdCurrency { get; set; }
    }
}
