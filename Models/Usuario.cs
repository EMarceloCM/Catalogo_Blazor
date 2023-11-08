using System.ComponentModel.DataAnnotations;

namespace TarefasBlazor.Models
{
    public class Usuario
    {
        public int Id { get; set; }
        
        [Required]
        [StringLength(20, ErrorMessage = "O nome não deve exceder 10 caracteres")]
        public string Nome { get; set; }

        [EmailAddress]
        public string Email { get; set; }

        [Range(18, 80, ErrorMessage = "A idade deve estar entre 18 e 80!")]
        public int Idade { get; set; }
    }
}
