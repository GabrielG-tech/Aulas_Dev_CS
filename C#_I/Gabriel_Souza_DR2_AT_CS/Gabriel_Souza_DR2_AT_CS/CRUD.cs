using System;
using System.Collections.Generic;
using System.Linq;
using static Gabriel_Souza_DR2_AT_CS.Utils;

namespace Gabriel_Souza_DR2_AT_CS {
    internal class CRUD {
        public static void IncluirConta(List<Conta> contas) {
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

        public static void AlterarSaldo(List<Conta> contas) {
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

            Conta conta = ValidarConta(contas, id);

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

        public static void ExcluirConta(List<Conta> contas) {
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

            Conta conta = ValidarConta(contas, id);

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

        public static void GerarRelatorios(List<Conta> contas) {
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
                    ListarClientesComSaldoNegativo(contas);
                    break;
                case 2:
                    ListarClientesComSaldoAcimaDe(contas);
                    break;
                case 3:
                    ListarTodasAsContas(contas);
                    break;
                default:
                    Console.WriteLine("Opção inválida.");
                    break;
            }
        }
    }
}
