using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfApp8.Model;

namespace WpfApp8.Helper
{
    class FindCurrency
    {
        int id;
        public FindCurrency(int id)
        {
            this.id = id;
        }
        public bool CurrencyPredicate(Currency currency)
        {
            return currency.ID == id;
        }
    }
}
