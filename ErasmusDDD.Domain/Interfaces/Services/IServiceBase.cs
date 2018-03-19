using System.Collections.Generic;

namespace ErasmusDDD.Domain.Interfaces.Services
{
    public interface IServiceBase<TEntity> where TEntity : class
    {
        void Add(TEntity obj);
        TEntity Get(int id);
        IEnumerable<TEntity> GetAll();
        void Edit(TEntity obj);
        void Remove(TEntity obj);
        void Dispose();
    }
}
