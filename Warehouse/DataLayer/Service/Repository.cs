using DataLayer.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : class
    {
        private readonly WarehouseEntities db;
        private readonly DbSet<TEntity> _dbSet;

        public Repository(WarehouseEntities warehouseContext)
        {
            db = warehouseContext;
            _dbSet = db.Set<TEntity>();
        }

        public IEnumerable<TEntity> GetAll()
        {
            return _dbSet.ToList();
        }

        public TEntity GetById(object id)
        {
            return _dbSet.Find(id);
        }

        public bool Delete(TEntity entity)
        {
            try
            {
                _dbSet.Remove(entity);
                return true;
            }
            catch
            {

                return false;
            }

        }

        public bool Delete(object id)
        {
            try
            {
                TEntity entity = GetById(id);
                Delete(entity);
                return true;
            }
            catch
            {

                return false;
            }

        }

        public bool Insert(TEntity entity)
        {
            try
            {
                // If TEntity's Id is Guid so this will generate a new Guid
                if (typeof(TEntity) == typeof(Products) || typeof(TEntity) == typeof(Receives) || typeof(TEntity) == typeof(Ships))
                {
                    Products product = new Products();
                    product = entity as Products;
                    product.Id = Guid.NewGuid();
                    _dbSet.Add(product as TEntity);
                    return true;

                }
                _dbSet.Add(entity);
                return true;
            }
            catch
            {
                return false;
            }

        }

        public bool Update(TEntity entity)
        {
            try
            {
                db.Entry(entity).State = EntityState.Modified;
                return true;
            }
            catch
            {

                return false;
            }

        }
    }
}
