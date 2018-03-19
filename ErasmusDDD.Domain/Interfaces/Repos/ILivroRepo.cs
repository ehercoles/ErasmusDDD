using ErasmusDDD.Domain.Entities;
using System.Collections.Generic;

namespace ErasmusDDD.Domain.Interfaces.Repos
{
    public interface ILivroRepo : IRepoBase<Livro>
    {
        IEnumerable<Livro> Search(string nome);
    }
}
