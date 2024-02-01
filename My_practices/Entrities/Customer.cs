﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My_practices.Entrities
{
    internal class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public List<Order> Orders { get; set; } = new List<Order>();

        public override string ToString()
        {
            return $"{this.Id}\t{this.Name}\t{this.Address}";
        }



    }
}
