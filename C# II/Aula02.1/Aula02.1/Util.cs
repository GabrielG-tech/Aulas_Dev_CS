using System;
using System.Collections.Generic;

namespace Aula02._1 {
    public class Util {
        public static int LerId() {
            Console.WriteLine("Entre com o id da conta: ");
            int id = int.Parse(Console.ReadLine());
            return id;
        }

        public static string LerNome() {
            Console.WriteLine("Entre com o nome: ");
            string nome = Console.ReadLine();
            return nome;
        }

        public static double LerSaldo() {
            Console.WriteLine("Entre com o saldo: ");
            double saldo = double.Parse(Console.ReadLine());
            return saldo;
        }

        public static bool PesquisarConta(List<Conta> contas, int id) {
            bool achou = false;
            foreach (Conta conta in contas) {
                if (conta.Id == id) {
                    achou = true;
                    break;
                }
            }

            return achou;
        }
    }
}
