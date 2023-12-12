using System.ComponentModel.DataAnnotations;

namespace InfnetWebApp.Models {
    public class Aluno {
        public int Id { get; set; }

        [Required(ErrorMessage = "O nome é obrigatório.")]
        [StringLength(50, MinimumLength = 4, ErrorMessage = "O nome deve ter entre 4 e 50 caracteres.")]
        public string Nome { get; set; }

        [StringLength(100, ErrorMessage = "O endereço não pode ter mais de 100 caracteres.")]
        public string Endereco { get; set; }

        [Phone(ErrorMessage = "O número de telefone não é válido.")]
        public string Telefone { get; set; }

        [EmailAddress(ErrorMessage = "O email não é válido.")]
        public string Email { get; set; }

        [Display(Name = "Data de Nascimento")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime DataNascimento { get; set; }
    }
}
