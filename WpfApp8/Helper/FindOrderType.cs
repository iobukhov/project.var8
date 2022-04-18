using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfApp8.Model;

namespace WpfApp8.Helper
{
    class FindOrderType
    {
        int id;
        public FindOrderType(int id)
        {
            this.id = id;
        }
        public bool OrderTypePredicate(OrderType type)
        {
            return type.ID == id;
        }
    }
}
