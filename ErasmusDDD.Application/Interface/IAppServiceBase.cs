using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ErasmusDDD.Application.Interface
{
    public interface IAppServiceBase<TEntity> where TEntity : class
    {
        void Add(TEntity obj);
        TEntity Get(int id);
        IEnumerable<TEntity> GetAll();
        void Edit(TEntity obj);
        void Remove(TEntity obj);
        void Dispose();
    }
}
