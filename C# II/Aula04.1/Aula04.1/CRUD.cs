using static Aula04._1.Util;
using System;
using System.Collections.Generic;

namespace Aula04._1 {
    public class CRUD {

        public static void IncluirConta(List<Conta> contas) {

            int id = LerId();
            bool achou = PesquisarConta(contas, id);
            if (achou) {
                Console.WriteLine("Erro: conta já existe");
                return;
            }
            string nome = LerNome();
            double saldo = LerSaldo();
            contas.Add(new Conta(id, nome, saldo));
        }

        public static void ExibirContas(List<Conta> contas) {
            foreach (Conta conta in contas) {
                Console.WriteLine(conta);
            }
        }
    }
}
