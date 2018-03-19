using ErasmusDDD.Application.Interface;
using ErasmusDDD.Domain.Entities;
using ErasmusDDD.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;

namespace ErasmusDDD.Application
{
    public class LivroAppService : AppServiceBase<Livro>, ILivroAppService
    {
        private readonly ILivroService _livroService;

        public LivroAppService(ILivroService livroService) : base(livroService)
        {
            _livroService = livroService;
        }

        public IEnumerable<Livro> Search(string nome)
        {
            return _livroService.Search(nome);
        }
    }
}
