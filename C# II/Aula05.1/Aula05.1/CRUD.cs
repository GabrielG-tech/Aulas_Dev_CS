using static Aula05._1.Util;
using static Aula05._1.CRUDdb;
using System;
using System.Collections.Generic;

namespace Aula05._1 {
    public class CRUD {

        public static void IncluirConta() {

            string nome = LerNome();
            double saldo = LerSaldo();
            Incluir(new Conta(0, nome, saldo));
        }

        public static void ExcluirConta() {

            int id = LerId();
            Conta conta = ConsultarConta(id);
            if (conta == null) {
                Console.WriteLine("Erro: conta não exite");
                return;
            }
            if (conta.Saldo > 0) {
                Console.WriteLine("Erro: saldo maior que zero");
                return;
            }
            Excluir(conta);
        }

        public static void ExibirContas() {

            List<Conta> contas = ConsultarContas();
            foreach (Conta conta in contas) {
                Console.WriteLine(conta);
            }
        }

        public static void ExibirConta() {

            int id = LerId();
            Conta conta = ConsultarConta(id);
            if (conta == null) {
                Console.WriteLine("Erro: conta não exite");
                return;
            }
            Console.WriteLine(conta);
        }
    }
}
