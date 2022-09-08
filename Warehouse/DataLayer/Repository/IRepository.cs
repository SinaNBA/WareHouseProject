using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    internal interface IRepository<TEntity>
    {
        IEnumerable<TEntity> GetAll();
        TEntity GetById(object id);
        bool Insert(TEntity entity);
        bool Update(TEntity entity);
        bool Delete(TEntity entity);
        bool Delete(object id);

    }
}
