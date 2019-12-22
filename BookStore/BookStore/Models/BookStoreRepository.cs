using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace BookStore.Models
{
    public class BookStoreRepository<T> : IGenericRepository<T> where T : class
    {
        StoreContext conn;

        public BookStoreRepository(StoreContext context)
        {
            conn = context;
        }
        public void Delete(int id)
        {
            T ToDelete = conn.Set<T>().Find(id);
            conn.Set<T>().Remove(ToDelete);
        }

        public T FindById(int entityId)
        {
            return conn.Set<T>().Find(entityId);
        }

        public IEnumerable<T> GetAll()
        {
            return conn.Set<T>().ToList();
        }

        public void Insert(T entity)
        {
            conn.Set<T>().Add(entity);
        }

        public void Update(T entity)
        {
            conn.Entry(entity).State = EntityState.Modified;
        }
    }
}