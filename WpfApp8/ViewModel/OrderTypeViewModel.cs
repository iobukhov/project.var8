using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using WpfApp8.Model;

namespace WpfApp8.ViewModel
{
    public class OrderTypeViewModel
    {
        public ObservableCollection<OrderType> ListType { get; set; } = new ObservableCollection<OrderType>();

        public OrderTypeViewModel()
        {
            this.ListType.Add(
                new OrderType
                {
                    ID = 1,
                    Type = "Брокерская"
                });
            this.ListType.Add(
                new OrderType
                {
                    ID = 2,
                    Type = "Дилерская"
                });
        }

        public int MaxId()
        {
            int max = 0;
            foreach (var r in this.ListType)
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
