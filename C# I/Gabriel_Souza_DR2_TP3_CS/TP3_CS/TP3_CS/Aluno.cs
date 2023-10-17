using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP3_CS {
    public class Aluno {
        public String Nome { get; set; }
        public String Telefone { get; set; }
        public String Matricula { get; set; }

        // Sobrecarga ou overload de construtor
        public Aluno() { }

        public Aluno(String nome, String telefone, String matricula) {
            Nome = nome;
            Telefone = telefone;
            Matricula = matricula;
        }
        public override string ToString() {
            return $"Aluno:\n Nome: {Nome}\nTelefone: {Telefone}\nMatricula: {Matricula}\n";
        }
    }
}
