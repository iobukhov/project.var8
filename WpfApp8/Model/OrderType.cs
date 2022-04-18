using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp8.Model
{
    public class OrderType
    {
        public int ID { get; set; }
        public string Type { get; set; }

        public OrderType() { }

        public OrderType(int id, string type)
        {
            this.ID = id;
            this.Type = type;
        }

        public OrderType ShallowCopy()
        {
            return (OrderType)this.MemberwiseClone();
        }
    }
}
