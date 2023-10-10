using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Gabriel_Souza_DR2_AT_CS {
    class Program {
        static List<Conta> contas = new List<Conta>();
        private static bool sairDoPrograma = false;
        private static string NOME_ARQUIVO = "C:\\Users\\Asus\\Documents\\Infnet_Bloco-BackEnd\\C#\\Aulas_Dev_CS\\Gabriel_Souza_DR2_AT_CS\\Gabriel_Souza_DR2_AT_CS\\conta.csv";

        static void Main(string[] args) {
            LerContasDoArquivo();

            while (!sairDoPrograma) {
                ExibirMenu();
                int escolha = Convert.ToInt32(Console.ReadLine());
                ProcessarEscolha(escolha);
            }
        }

        private static void ExibirMenu() {
            Console.WriteLine("============== MENU ==============");
            Console.WriteLine("[1] - Inclusão de conta");
            Console.WriteLine("[2] - Alteração de saldo");
            Console.WriteLine("[3] - Exclusão de conta");
            Console.WriteLine("[4] - Relatórios gerenciais");
            Console.WriteLine("[5] - Sair do programa");
            Console.WriteLine("==================================");
            Console.Write("Escolha uma opção: ");
        }

        static void ProcessarEscolha(int escolha) {
            switch (escolha) {
                case 1:
                    IncluirConta();
                    break;
                case 2:
                    AlterarSaldo();
                    break;
                case 3:
                    ExcluirConta();
                    break;
                case 4:
                    GerarRelatorios();
                    break;
                case 5:
                    GravarContasNoArquivo();
                    sairDoPrograma = true;
                    break;
                default:
                    Console.WriteLine("Opção inválida.");
                    break;
            }
        }

        static void IncluirConta() {
            Console.Write("Digite o número da conta: ");
            int id = ValidarId();

            if (id <= 0) {
                Console.WriteLine("Número de conta inválido.");
                return;
            }

            if (contas.Any(c => c.Id == id)) {
                Console.WriteLine("Conta com esse número já existe.");
                return;
            }

            Console.Write("Digite o nome do correntista (pelo menos dois nomes): ");
            string nome = Console.ReadLine();

            if (nome.Split(' ').Length < 2) {
                Console.WriteLine("Nome inválido. Deve conter pelo menos dois nomes.");
                return;
            }

            Console.Write("Digite o saldo inicial: ");
            double saldo = ValidarSaldo();

            if (saldo < 0) {
                Console.WriteLine("Saldo inicial inválido.");
                return;
            }

            Conta conta = new Conta(id, nome, saldo);
            contas.Add(conta);
            Console.WriteLine("Conta criada com sucesso!");
        }

        static int ValidarId() {
            int id;

            try {
                id = Convert.ToInt32(Console.ReadLine());
            } catch (FormatException) {
                Console.WriteLine("Número de conta inválido.");
                return -1;
            }

            return id;
        }

        static double ValidarSaldo() {
            double saldo;

            try {
                saldo = Convert.ToDouble(Console.ReadLine());
            } catch (FormatException) {
                Console.WriteLine("Saldo inicial inválido.");
                return -1;
            }

            return saldo;
        }

        static void AlterarSaldo() {
            if (contas.Count == 0) {
                Console.WriteLine("Nenhuma conta cadastrada.");
                return;
            }

            Console.Write("Digite o número da conta que deseja alterar o saldo: ");
            int id = ValidarId();

            if (id <= 0) {
                Console.WriteLine("Número de conta inválido.");
                return;
            }

            Conta conta = ValidarConta(id);

            if (conta == null) {
                Console.WriteLine("Conta não encontrada.");
                return;
            }

            Console.Write("Digite o valor do crédito ou débito: ");
            double valor = ValidarSaldo();

            if (valor <= 0) {
                Console.WriteLine("Valor inválido.");
                return;
            }

            Console.WriteLine(" [1] para crédito\n  [2] para débito");
            Console.Write("Escolha uma das opções acima: ");
            int opcao = ValidarOpcao();

            if (opcao == -1) {
                Console.WriteLine("Opção inválida.");
                return;
            }

            if (opcao == 1) {
                conta.Creditar(valor);
                // Obs: valor:C transforma valor para formato monetario
                Console.WriteLine($"Crédito de {valor:C} realizado com sucesso.");
            } else if (opcao == 2) {
                if (conta.Saldo >= valor) {
                    conta.Debitar(valor);
                    Console.WriteLine($"Débito de {valor:C} realizado com sucesso.");
                } else {
                    Console.WriteLine("Saldo insuficiente para realizar o débito.");
                }
            } else {
                Console.WriteLine("Opção inválida.");
            }
        }

        static int ValidarOpcao() {
            int opcao;

            try {
                opcao = Convert.ToInt32(Console.ReadLine());
            } catch (FormatException) {
                Console.WriteLine("Opção inválida.");
                return -1;
            }

            return opcao;
        }

        static Conta ValidarConta(int id) {
            for (int i = 0; i < contas.Count; i++) {
                if (contas[i].Id == id) {
                    return contas[i];
                }
            }
            return null;
        }

        static void ExcluirConta() {
            if (contas.Count == 0) {
                Console.WriteLine("Nenhuma conta cadastrada.");
                return;
            }

            Console.Write("Digite o número da conta que deseja excluir: ");
            int id = ValidarId();

            if (id <= 0) {
                Console.WriteLine("Número de conta inválido.");
                return;
            }

            Conta conta = ValidarConta(id);

            if (conta == null) {
                Console.WriteLine("Conta não encontrada.");
                return;
            }

            if (conta.Saldo == 0) {
                contas.Remove(conta);
                Console.WriteLine("Conta excluída com sucesso.");
            } else {
                Console.WriteLine("Não é possível excluir uma conta com saldo diferente de zero.");
            }
        }

        static void GerarRelatorios() {
            if (contas.Count == 0) {
                Console.WriteLine("Nenhuma conta cadastrada.");
                return;
            }

            Console.WriteLine("Opções de relatórios gerenciais:");
            Console.WriteLine(" [1] Listar clientes com saldo negativo");
            Console.WriteLine(" [2] Listar clientes com saldo acima de um valor");
            Console.WriteLine(" [3] Listar todas as contas");
            Console.Write("Escolha uma opção: ");

            int opcao = ValidarOpcao();

            if (opcao == -1) {
                Console.WriteLine("Opção inválida.");
                return;
            }

            switch (opcao) {
                case 1:
                    ListarClientesComSaldoNegativo();
                    break;
                case 2:
                    ListarClientesComSaldoAcimaDe();
                    break;
                case 3:
                    ListarTodasAsContas();
                    break;
                default:
                    Console.WriteLine("Opção inválida.");
                    break;
            }
        }

        static void ListarClientesComSaldoNegativo() {
            Console.WriteLine("Clientes com saldo negativo:");
            foreach (Conta conta in contas) {
                if (conta.Saldo < 0) {
                    Console.WriteLine(conta);
                }
            }
        }

        static void ListarClientesComSaldoAcimaDe() {
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

        static void ListarTodasAsContas() {
            Console.WriteLine("Todas as contas:");
            foreach (Conta conta in contas) {
                Console.WriteLine(conta);
            }
        }

        static void LerContasDoArquivo() {
            if (File.Exists(NOME_ARQUIVO)) {
                string[] linhas = File.ReadAllLines(NOME_ARQUIVO);
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

        static void GravarContasNoArquivo() {
            using (StreamWriter writer = new StreamWriter(NOME_ARQUIVO)) {
                foreach (Conta conta in contas) {
                    writer.WriteLine($"{conta.Id};{conta.Nome};{conta.Saldo}");
                }
            }
        }
    }
}
