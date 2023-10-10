using System;
using System.Collections.Generic;
using System.IO;

namespace Gabriel_Souza_DR2_AT_CS {
    internal class Utils {
        const string NOME_ARQUIVO = "conta.csv";
        const string DIRETORIO = "C:\\Users\\Asus\\Documents\\Infnet_Bloco-BackEnd\\C#\\Aulas_Dev_CS\\Gabriel_Souza_DR2_AT_CS\\Gabriel_Souza_DR2_AT_CS";
        private static string CAMINHO = Path.Combine(DIRETORIO, NOME_ARQUIVO);
        public static void ExibirMenu() {
            Console.WriteLine("============== MENU ==============");
            Console.WriteLine("[1] - Inclusão de conta");
            Console.WriteLine("[2] - Alteração de saldo");
            Console.WriteLine("[3] - Exclusão de conta");
            Console.WriteLine("[4] - Relatórios gerenciais");
            Console.WriteLine("[5] - Sair do programa");
            Console.WriteLine("==================================");
            Console.Write("Escolha uma opção: ");
        }

        public static int ValidarId() {
            int id;

            try {
                id = Convert.ToInt32(Console.ReadLine());
            } catch (FormatException) {
                return -1;
            }

            return id;
        }

        public static double ValidarSaldo() {
            double saldo;

            try {
                saldo = Convert.ToDouble(Console.ReadLine());
            } catch (FormatException) {
                return -1;
            }

            return saldo;
        }

        public static int ValidarOpcao() {
            int opcao;

            try {
                opcao = Convert.ToInt32(Console.ReadLine());
            } catch (FormatException) {
                return -1;
            }

            return opcao;
        }

        public static Conta ValidarConta(List<Conta> contas, int id) {
            for (int i = 0; i < contas.Count; i++) {
                if (contas[i].Id == id) {
                    return contas[i];
                }
            }
            return null;
        }

        public static void ListarClientesComSaldoNegativo(List<Conta> contas) {
            Console.WriteLine("Clientes com saldo negativo:");
            foreach (Conta conta in contas) {
                if (conta.Saldo < 0) {
                    Console.WriteLine(conta);
                }
            }
        }

        public static void ListarClientesComSaldoAcimaDe(List<Conta> contas) {
            Console.Write("Digite o valor mínimo de saldo: ");
            double valorMinimo = ValidarSaldo();

            if (valorMinimo < 0) {
                Console.WriteLine("Valor inválido.");
                return;
            }

            Console.WriteLine($"Clientes com saldo acima de {valorMinimo:C}:");
            foreach (Conta conta in contas) {
                if (conta.Saldo >= valorMinimo) {
                    Console.WriteLine(conta);
                }
            }
        }

        public static void ListarTodasAsContas(List<Conta> contas) {
            Console.WriteLine("Todas as contas:");
            foreach (Conta conta in contas) {
                Console.WriteLine(conta);
            }
        }

        public static void LerContasDoArquivo(List<Conta> contas) {
            if (File.Exists(CAMINHO)) {
                string[] linhas = File.ReadAllLines(CAMINHO);
                foreach (string linha in linhas) {
                    string[] partes = linha.Split(';');
                    if (partes.Length == 4) {
                        int id;
                        string nome = partes[1];
                        double saldo;

                        try {
                            id = Convert.ToInt32(partes[0]);
                            saldo = Convert.ToDouble(partes[3]);

                            Conta conta = new Conta(id, nome, saldo);
                            contas.Add(conta);
                        } catch (FormatException) {
                            Console.WriteLine("Erro ao ler os dados da conta.");
                        }
                    }
                }
            }
        }

        public static void GravarContasNoArquivo(List<Conta> contas) {
            using (StreamWriter writer = new StreamWriter(CAMINHO)) {
                foreach (Conta conta in contas) {
                    writer.WriteLine($"{conta.Id};{conta.Nome};{conta.Saldo}");
                }
            }
        }
    }
}
