using System.ComponentModel.DataAnnotations;

namespace BancoWebApp.Models {
    public class Conta {
        public int Id { get; set; }

        [StringLength(50, MinimumLength = 4, ErrorMessage = "O nome deve ter no mínimo 4 caracateres")]
        [Required(ErrorMessage = "O nome é obrigatório")]
        [Display(Name = "Nome do cliente")]
        public string Nome { get; set; }

        [DataType(DataType.Currency)]
        [Range(1, 1000, ErrorMessage ="O saldo deve estar entre 1 e 1000")]
        public double Saldo {  get; set; }

        public Conta() { }

        public Conta(int id, string nome, double saldo) {
            Id = id;
            Nome = nome;
            Saldo = saldo;
        }
    }
}
