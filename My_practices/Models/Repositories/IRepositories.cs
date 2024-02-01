using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My_practices.Models.Repositories
{
    internal interface IRepositories<IEntity>
    {
        void Add(IEntity entity);
        IList<IEntity> GetAll();
        void Update(int id, IEntity entity);
        IEntity find(int id);
        void Delete(int id);
    }
}
