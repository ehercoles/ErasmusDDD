using ErasmusDDD.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ErasmusDDD.Application.Interface
{
    public interface ILivroAppService : IAppServiceBase<Livro>
    {
        IEnumerable<Livro> Search(string nome);
    }
}
