using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfApp8.Model;

namespace WpfApp8.Helper
{
    class FindOrderVeriety
    {
        int id;
        public FindOrderVeriety(int id)
        {
            this.id = id;
        }
        public bool OrderVerietyPredicate(OrderVeriety veriety)
        {
            return veriety.ID == id;
        }
    }
}
