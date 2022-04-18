using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfApp8.ViewModel;

namespace WpfApp8.Model
{
    public class Order
    {
        public int ID { get; set; }
        public int OrderTypeID { get; set; }
        public int OrderVerietyID { get; set; }
        public int CurrencyID { get; set; }
        public int Tiker { get; set; }
        public int Count { get; set; }
        public int Number { get; set; }
        public DateTime Data { get; set; }
        public DateTime Duration { get; set; }

        public Order() { }

        public Order(int id, int orderTypeID, int orderVerietyID, int currencyID,
                    int tiker, int count, int number, DateTime data, DateTime duration)
        {
            this.ID = id;
            this.OrderTypeID = orderTypeID;
            this.OrderVerietyID = orderVerietyID;
            this.CurrencyID = currencyID;
            this.Tiker = tiker;
            this.Count = count;
            this.Number = number;
            this.Data = data;
            this.Duration = duration;
        }

        public Order CopyFromOrderDPO(OrderDPO p)
        {
            CurrencyViewModel vmCurrency = new CurrencyViewModel();
            OrderTypeViewModel vmType = new OrderTypeViewModel();
            OrderVerietyViewModel vmVeriety = new OrderVerietyViewModel();
            int currencyId = 0;
            int typeId = 0;
            int verietyId = 0;
            foreach (var r in vmCurrency.ListCurrency)
            {
                if (r.CurrencyShort == p.Currency)
                {
                    currencyId = r.ID;
                    break;
                }
            }
            foreach (var r in vmType.ListType)
            {
                if (r.Type == p.OrderType)
                {
                    typeId = r.ID;
                    break;
                }
            }
            foreach (var r in vmVeriety.ListVeriety)
            {
                if (r.Veriety == p.OrderVeriety)
                {
                    verietyId = r.ID;
                    break;
                }
            }
            if (currencyId != 0 && typeId != 0 && verietyId != 0)
            {
                this.ID = p.ID;
                this.OrderTypeID = typeId;
                this.OrderVerietyID = verietyId;
                this.CurrencyID = currencyId;
                this.Tiker = p.Tiker;
                this.Count = p.Count;
                this.Number = p.Number;
                this.Data = p.Data;
                this.Duration = p.Duration;
            }
            return this;
        }

        public Order ShallowCopy()
        {
            return (Order)this.MemberwiseClone();
        }
    }
}
