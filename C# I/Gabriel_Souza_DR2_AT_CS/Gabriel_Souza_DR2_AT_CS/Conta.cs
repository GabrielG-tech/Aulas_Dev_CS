using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gabriel_Souza_DR2_AT_CS {
    class Conta: IConta {
        public int Id {
            get; set;
        }
        public string Nome {
            get; set;
        }
        public double Saldo {
            get; set;
        }

        public Conta(int id, string nome, double saldo) {
            Id = id;
            Nome = nome;
            Saldo = saldo;
        }

        public void Creditar(double valor) {
            if (valor <= 0) {
                Console.WriteLine("O valor de crédito deve ser maior que zero.");
            } else {
                Saldo += valor;
            }
        }

        public void Debitar(double valor) {
            if (valor <= 0) {
                Console.WriteLine("O valor de débito deve ser maior que zero.");
            } else if (Saldo < valor) {
                Console.WriteLine("Saldo insuficiente para realizar o débito.");
            } else {
                Saldo -= valor;
            }
        }

        public override string ToString() {
            return $"Conta: {Id}, Nome: {Nome}, Saldo: {Saldo:C}";
        }
    }
}
