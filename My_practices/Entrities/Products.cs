using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My_practices.Entrities
{
    internal class Products
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int UnitOfStock {  get; set; }
        public decimal Price { get; set; }
        public string ImgUrl {  get; set; }
        public int CategoryId {  get; set; }

        public Category Category { get; set; }

    }
}
