using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using WpfApp8.Model;

namespace WpfApp8.ViewModel
{
    class OrderVerietyViewModel
    {
        public ObservableCollection<OrderVeriety> ListVeriety { get; set; } = new ObservableCollection<OrderVeriety>();

        public OrderVerietyViewModel()
        {
            this.ListVeriety.Add(
                new OrderVeriety
                {
                    ID = 1,
                    Veriety = "Покупка"
                });
            this.ListVeriety.Add(
                new OrderVeriety
                {
                    ID = 2,
                    Veriety = "Продажа"
                });
        }

        public int MaxId()
        {
            int max = 0;
            foreach (var r in this.ListVeriety)
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
