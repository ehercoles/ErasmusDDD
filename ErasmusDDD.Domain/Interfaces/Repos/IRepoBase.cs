using System.Collections.Generic;

namespace ErasmusDDD.Domain.Interfaces.Repos
{
    public interface IRepoBase<TEntity> where TEntity : class
    {
        void Add(TEntity obj);
        TEntity Get(int id);
        IEnumerable<TEntity> GetAll();
        void Edit(TEntity obj);
        void Remove(TEntity obj);
        void Dispose();
    }
}
