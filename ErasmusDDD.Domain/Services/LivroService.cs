using System.Collections.Generic;
using ErasmusDDD.Domain.Entities;
using ErasmusDDD.Domain.Interfaces.Repos;
using ErasmusDDD.Domain.Interfaces.Services;

namespace ErasmusDDD.Domain.Services
{
    public class LivroService : ServiceBase<Livro>, ILivroService
    {
        private readonly ILivroRepo _livroRepo;

        public LivroService(ILivroRepo livroRepo) : base(livroRepo)
        {
            _livroRepo = livroRepo;
        }

        public IEnumerable<Livro> Search(string nome)
        {
            return _livroRepo.Search(nome);
        }
    }
}
