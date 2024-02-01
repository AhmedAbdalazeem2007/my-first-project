using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My_practices.Models
{
     class Author
    {
        public int Id { get; set; }
        public string Fullname { get; set; }
        public List<Book> Books { get; set; }
    }
}
