using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfApp8.Model;

namespace WpfApp8.Helper
{
    class FindOrder
    {
        int id;
        public FindOrder(int id)
        {
            this.id = id;
        }
        public bool OrderPredicate(Order order)
        {
            return order.ID == id;
        }
    }
}
