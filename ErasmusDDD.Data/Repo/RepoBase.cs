using ErasmusDDD.Data.Context;
using ErasmusDDD.Domain.Interfaces.Repos;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ErasmusDDD.Data.Repo
{
    public class RepoBase<TEntity> : IDisposable, IRepoBase<TEntity> where TEntity : class
    {
        protected ErasmusDDDContext db = new ErasmusDDDContext();

        public void Add(TEntity obj)
        {
            db.Set<TEntity>().Add(obj);
            db.SaveChanges();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public void Edit(TEntity obj)
        {
            db.Entry(obj).State = System.Data.Entity.EntityState.Modified;
            db.SaveChanges();
        }

        public TEntity Get(int id)
        {
            return db.Set<TEntity>().Find(id);
        }

        public IEnumerable<TEntity> GetAll()
        {
            // Fix: Force assembly to be loaded
            System.Type providerService = typeof(System.Data.Entity.SqlServer.SqlProviderServices);

            return db.Set<TEntity>().ToList();
        }

        public void Remove(TEntity obj)
        {
            db.Set<TEntity>().Remove(obj);
            db.SaveChanges();
        }
    }
}
