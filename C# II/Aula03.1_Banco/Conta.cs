using System;

namespace Aula03._1_Banco {
    public class Conta : IConta {
        public int Id { get; set; }
        public string Nome { get; set; }
        public double Saldo { get; set; }
        public Conta() {}
        
        public Conta(int id, string nome, double saldo) {
            Id = id;
            Nome = nome;
            Saldo = saldo;
        }

        public void Creditar(double valor) {
            Saldo += valor;
        }
        public void Debitar(double valor) {
            Saldo -= valor;
        }

        public override string ToString() {
            return Id + " - " + Nome + "\t " + Saldo;
        }
    }
}
