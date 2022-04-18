using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp8.Model
{
    public class OrderVeriety
    {
        public int ID { get; set; }
        public string Veriety { get; set; }

        public OrderVeriety() { }

        public OrderVeriety(int id, string veriety)
        {
            this.ID = id;
            this.Veriety = veriety;
        }

        public OrderVeriety ShallowCopy()
        {
            return (OrderVeriety)this.MemberwiseClone();
        }
    }
}
