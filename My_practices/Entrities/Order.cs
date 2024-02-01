using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My_practices.Entrities
{
    internal class Order
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime DateOrder { get; set; }
        public int CustomerId { get; set; }
        public Customer Customer { get; set; }
    }
}
