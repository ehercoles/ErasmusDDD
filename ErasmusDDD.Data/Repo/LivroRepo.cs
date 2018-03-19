using System.Collections.Generic;
using System.Linq;
using ErasmusDDD.Domain.Entities;
using ErasmusDDD.Domain.Interfaces.Repos;

namespace ErasmusDDD.Data.Repo
{
    public class LivroRepo : RepoBase<Livro>, ILivroRepo
    {
        public IEnumerable<Livro> Search(string nome)
        {
            return db.Livros.Where(x => x.Nome.Contains(nome));
        }
    }
}
