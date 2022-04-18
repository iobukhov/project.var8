using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp8.Model
{
    public class Currency
    {
        public int ID { get; set; }
        public string CurrencyFull { get; set; }
        public string CurrencyShort { get; set; }

        public Currency() { }

        public Currency(int id, string currencyFull, string currencyShort)
        {
            this.ID = id;
            this.CurrencyFull = currencyFull;
            this.CurrencyShort = currencyShort;
        }

        public Currency ShallowCopy()
        {
            return (Currency)this.MemberwiseClone();
        }
    }
}
