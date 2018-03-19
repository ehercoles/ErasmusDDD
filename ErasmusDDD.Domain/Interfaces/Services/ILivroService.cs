using ErasmusDDD.Domain.Entities;
using System.Collections.Generic;

namespace ErasmusDDD.Domain.Interfaces.Services
{
    public interface ILivroService : IServiceBase<Livro>
    {
        IEnumerable<Livro> Search(string nome);
    }
}
