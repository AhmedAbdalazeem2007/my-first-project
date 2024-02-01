using My_practices.Entrities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My_practices.Repository
{
    internal interface IEmployeerepos
    {
        public List<Employee> GetAll();
        public Employee GetById(int id);
        public Employee GetById(string id);
    }
}
