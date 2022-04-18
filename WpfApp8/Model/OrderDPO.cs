using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfApp8.ViewModel;

namespace WpfApp8.Model
{
    public class OrderDPO
    {
        public int ID { get; set; }
        public string OrderType { get; set; }
        public string OrderVeriety { get; set; }
        public string Currency { get; set; }
        public int Tiker { get; set; }
        public int Count { get; set; }
        public int Number { get; set; }
        public DateTime Data { get; set; }
        public DateTime Duration { get; set; }

        public OrderDPO() { }

        public OrderDPO(int id, string orderType, string orderVeriety, string currency,
                    int tiker, int count, int number, DateTime data, DateTime duration)
        {
            this.ID = id;
            this.OrderType = orderType;
            this.OrderVeriety = orderVeriety;
            this.Currency = currency;
            this.Tiker = tiker;
            this.Count = count;
            this.Number = number;
            this.Data = data;
            this.Duration = duration;
        }

        public OrderDPO CopyFromOrder(Order order)
        {
            OrderDPO deDPO = new OrderDPO();
            CurrencyViewModel vmCurrency = new CurrencyViewModel();
            OrderTypeViewModel vmType = new OrderTypeViewModel();
            OrderVerietyViewModel vmVeriety = new OrderVerietyViewModel();
            string currency = string.Empty;
            string type = string.Empty;
            string veriety = string.Empty;
            foreach (var r in vmCurrency.ListCurrency)
            {
                if (r.ID == order.CurrencyID)
                {
                    currency = r.CurrencyShort;
                    break;
                }
            }
            foreach (var r in vmType.ListType)
            {
                if (r.ID == order.OrderTypeID)
                {
                    type = r.Type;
                    break;
                }
            }
            foreach (var r in vmVeriety.ListVeriety)
            {
                if (r.ID == order.OrderVerietyID)
                {
                    veriety = r.Veriety;
                    break;
                }
            }
            if (currency != string.Empty && type != string.Empty && veriety != string.Empty)
            {
                deDPO.ID = order.ID;
                deDPO.OrderType = type;
                deDPO.OrderVeriety = veriety;
                deDPO.Currency = currency;
                deDPO.Tiker = order.Tiker;
                deDPO.Count = order.Count;
                deDPO.Number = order.Number;
                deDPO.Data = order.Data;
                deDPO.Duration = order.Duration;
            }
            return deDPO;
        }

        public OrderDPO ShallowCopy()
        {
            return (OrderDPO)this.MemberwiseClone();
        }
    }
}
