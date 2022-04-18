using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using WpfApp8.Model;

namespace WpfApp8.ViewModel
{
    public class OrderViewModel
    {
        public ObservableCollection<Order> ListOrder { get; set; } = new ObservableCollection<Order>();

        public OrderViewModel()
        {
            this.ListOrder.Add(
                new Order
                {
                    ID = 1,
                    OrderTypeID = 1,
                    OrderVerietyID = 1,
                    CurrencyID = 1,
                    Tiker = 545465,
                    Count = 15,
                    Number = 458941,
                    Data = new DateTime(2020, 04, 09)
                });
            this.ListOrder.Add(
                new Order
                {
                    ID = 2,
                    OrderTypeID = 2,
                    OrderVerietyID = 2,
                    CurrencyID = 1,
                    Tiker = 894151,
                    Count = 10,
                    Number = 624894,
                    Data = new DateTime(2020, 04, 09)
                });
            this.ListOrder.Add(
                new Order
                {
                    ID = 3,
                    OrderTypeID = 1,
                    OrderVerietyID = 2,
                    CurrencyID = 2,
                    Tiker = 156489,
                    Count = 35,
                    Number = 516556,
                    Data = new DateTime(2020, 04, 09)
                });
        }

        public int MaxId()
        {
            int max = 0;
            foreach (var r in this.ListOrder)
            {
                if (max < r.ID)
                {
                    max = r.ID;
                };
            }
            return max;
        }
    }
}
