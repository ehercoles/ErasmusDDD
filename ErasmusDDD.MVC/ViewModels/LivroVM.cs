using System.ComponentModel.DataAnnotations;

namespace ErasmusDDD.MVC.ViewModels
{
    public class LivroVM
    {
        [Key]
        public int LivroId { get; set; }

        [Required(ErrorMessage = "Campo obrigatório"), StringLength(80)]
        public string Nome { get; set; }
    }
}
