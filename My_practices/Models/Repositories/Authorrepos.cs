using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My_practices.Models.Repositories
{
    internal class Authorrepos : IRepositories<Author>
    {
        IList<Author> _authors;
        public Authorrepos() {
            _authors = new List<Author>()
            {

            };

        }
        public void Add(Author entity)
        {
            _authors.Add(entity);
        }

        public void Delete(int id)
        {
            var a= _authors.SingleOrDefault((p)=>p.Id==id);
            _authors.Remove(a);
        }

        public Author find(int id)
        {
            var a = _authors.SingleOrDefault((i) => i.Id == id);
            return a;
        }

        public IList<Author> GetAll()
        {
            return _authors;
        }

        public void Update(int id,Author entity)
        {
            var a = _authors.SingleOrDefault((i) => i.Id == id);
            a.Fullname = entity.Fullname;
            a.Id = entity.Id;
            
        }
    }
}
