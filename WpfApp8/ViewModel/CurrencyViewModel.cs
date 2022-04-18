using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using WpfApp8.Model;

namespace WpfApp8.ViewModel
{
    public class CurrencyViewModel
    {
        public ObservableCollection<Currency> ListCurrency { get; set; } = new ObservableCollection<Currency>();

        public CurrencyViewModel()
        {
            this.ListCurrency.Add(
                new Currency
                {
                    ID = 1,
                    CurrencyFull = "Российский рубль",
                    CurrencyShort = "RUB"
                });
            this.ListCurrency.Add(
                new Currency
                {
                    ID = 2,
                    CurrencyFull = "Евро",
                    CurrencyShort = "EUR"
                });
            this.ListCurrency.Add(
                new Currency
                {
                    ID = 3,
                    CurrencyFull = "Доллар США",
                    CurrencyShort = "USD"
                });
        }

        public int MaxId()
        {
            int max = 0;
            foreach (var r in this.ListCurrency)
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
