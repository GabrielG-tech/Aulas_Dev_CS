using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula01._1 {
    public class Conta {
        public int Id { get; set; }
        public string? Nome { get; set; }
        public double Saldo { get; set; }

        public Conta() { }

        public Conta(int id, string nome, double saldo) {
            Id = id;
            Nome = nome;
            Saldo = saldo;
        }

        public void Creditar(double valor) {
            if (valor > 0) {
                Console.WriteLine("Erro: valor invalido");
                return;
            }
            Saldo += valor;
        }

        public void Debitar(double valor) {
            if (valor > 0) {
                Console.WriteLine("Erro: valor invalido");
                return;
            }
            Saldo += valor;
        }
    }
}
