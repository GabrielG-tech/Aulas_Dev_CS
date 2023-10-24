using System;
using System.Collections.Generic;
using static Aula02._1.Util;

namespace Aula02._1 {
    public class CRUD {
        public static void IncluirConta(List<Conta> contas) {
            int id;

            id = LerId();
            bool achou = PesquisarConta(contas, id);
            if (achou) {
                Console.WriteLine("Erro: conta já existe");
                return;
            }
            string nome = LerNome();

            double saldo = LerSaldo();
        }

        public static void ExibirContas(List<Conta> contas) {
            foreach (Conta conta in contas) {
                Console.WriteLine(conta.ToString());
            }
        }
    }
}
