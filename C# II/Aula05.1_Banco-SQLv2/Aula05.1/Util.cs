using System;
using System.Collections.Generic;

namespace Aula05._1 {
    public class Util {

        public static int EntrarInteiro(string msg) {
            int num = 0;

            do {
                try {
                    Console.Write(msg);
                    num = int.Parse(Console.ReadLine());
                    break;
                } catch (Exception e) {
                    Console.WriteLine("Erro: valor inválido - " + e);
                }
            } while (true);
            return num;
        }

        public static int LerId() {
            int id;
            bool idOk = false;

            do {
                id = EntrarInteiro("Entre com o id da conta: ");

                if (id > 0) {
                    idOk = true;
                } else {
                    Console.WriteLine("Erro: id inválido");
                }

            } while (!idOk);
            return id;
        }

        public static string LerNome() {
            Console.Write("Entre com o nome: ");
            string nome = Console.ReadLine();
            return nome;
        }

        public static double LerSaldo() {
            Console.Write("Entre com o saldo: ");
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
