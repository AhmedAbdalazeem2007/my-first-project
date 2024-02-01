using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My_practices.Models.Repositories
{
    internal class Bookrepos : IRepositories<Book>
    {
        public void Add(Book entity)
        {

        }

        public void Delete(int id)
        {
            return;
        }

        public Book find(int id)
        {
            return null;
        }

        public IList<Book> GetAll()
        {
            throw new NotImplementedException();
        }

        public void Update(int id, Book entity)
        {
            throw new NotImplementedException();
        }
    }
}
