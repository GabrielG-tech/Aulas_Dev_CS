using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP3_CS {
    public class Funcionario {
        public String Nome { get; set; }
        public String Telefone { get; set; }
        public String Cargo { get; set; }

        // Sobrecarga ou overload de construtor
        public Funcionario() { }

        public Funcionario(String nome, String telefone, String cargo) {
            Nome = nome;
            Telefone = telefone;
            Cargo = cargo;
        }
    }
}
