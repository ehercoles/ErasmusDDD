using ErasmusDDD.Domain.Interfaces.Repos;
using ErasmusDDD.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ErasmusDDD.Domain.Services
{
    public class ServiceBase<TEntity> : IDisposable, IServiceBase<TEntity> where TEntity : class
    {
        private readonly IRepoBase<TEntity> _repo;

        public ServiceBase(IRepoBase<TEntity> repo)
        {
            _repo = repo;
        }

        public void Add(TEntity obj)
        {
            _repo.Add(obj);
        }

        public void Dispose()
        {
            _repo.Dispose();
        }

        public void Edit(TEntity obj)
        {
            _repo.Edit(obj);
        }

        public TEntity Get(int id)
        {
            return _repo.Get(id);
        }

        public IEnumerable<TEntity> GetAll()
        {
            return _repo.GetAll();
        }

        public void Remove(TEntity obj)
        {
            _repo.Remove(obj);
        }
    }
}
