using System.ComponentModel.DataAnnotations;

namespace ErasmusDDD.Domain.Entities
{
    public class Livro
    {
        public int LivroId { get; set; }

        [Required, StringLength(80)]
        public string Nome { get; set; }
    }
}
