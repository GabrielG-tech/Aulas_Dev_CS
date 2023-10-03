using System;
using System.Collections.Generic;
<<<<<<< HEAD
using System.IO;
using System.Linq;

namespace Gabriel_Souza_DR2_AT_CS {
    internal class Program {
        static List<Conta> contas = new List<Conta>();
        static string arquivoContas = "contas.csv";

        static void Main(string[] args) {
            CarregarContasDoArquivo();

            while (true) {
                Console.WriteLine("MENU:");
                Console.WriteLine("1 - Inclusão de conta");
                Console.WriteLine("2 - Alteração de saldo");
                Console.WriteLine("3 - Exclusão de conta");
                Console.WriteLine("4 - Relatórios gerenciais");
                Console.WriteLine("5 - Sair do programa");

                Console.Write("Escolha uma opção: ");
                int opcao;
                if (int.TryParse(Console.ReadLine(), out opcao)) {
                    switch (opcao) {
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
                        RelatoriosGerenciais();
                        break;
                        case 5:
                        SalvarContasNoArquivo();
                        Environment.Exit(0);
                        break;
                        default:
                        Console.WriteLine("Opção inválida. Tente novamente.");
                        break;
                    }
                } else {
                    Console.WriteLine("Opção inválida. Tente novamente.");
                }
            }
        }

        static void IncluirConta() {
            Console.WriteLine("Inclusão de conta:");
            Console.Write("Número da conta: ");
            int numeroConta;
            if (!int.TryParse(Console.ReadLine(), out numeroConta) || numeroConta <= 0) {
                Console.WriteLine("Número da conta inválido.");
                return;
            }

            if (contas.Any(c => c.NumeroConta == numeroConta)) {
                Console.WriteLine("Essa conta já existe.");
                return;
            }

            Console.Write("Nome do correntista: ");
            string nome = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(nome) || !nome.Contains(" ")) {
                Console.WriteLine("Nome inválido. Deve conter pelo menos nome e sobrenome.");
                return;
            }

            Console.Write("Saldo inicial: ");
            double saldoInicial;
            if (!double.TryParse(Console.ReadLine(), out saldoInicial) || saldoInicial < 0) {
                Console.WriteLine("Saldo inicial inválido.");
                return;
            }

            Conta novaConta = new Conta(numeroConta, nome, saldoInicial);
            contas.Add(novaConta);
            Console.WriteLine("Conta criada com sucesso.");
        }

        static void AlterarSaldo() {
            Console.WriteLine("Alteração de saldo:");
            if (contas.Count == 0) {
                Console.WriteLine("Não há contas para alterar.");
                return;
            }

            Console.Write("Número da conta: ");
            int numeroConta;
            if (!int.TryParse(Console.ReadLine(), out numeroConta) || numeroConta <= 0) {
                Console.WriteLine("Número da conta inválido.");
                return;
            }

            Conta conta = contas.FirstOrDefault(c => c.NumeroConta == numeroConta);
            if (conta == null) {
                Console.WriteLine("Conta não encontrada.");
                return;
            }

            Console.Write("Valor a ser creditado ou debitado: ");
            double valor;
            if (!double.TryParse(Console.ReadLine(), out valor) || valor <= 0) {
                Console.WriteLine("Valor inválido.");
                return;
            }

            Console.Write("Deseja realizar um crédito (C) ou débito (D)? ");
            char operacao = Console.ReadLine().ToUpper().FirstOrDefault();
            if (operacao != 'C' && operacao != 'D') {
                Console.WriteLine("Operação inválida.");
                return;
            }

            try {
                if (operacao == 'C')
                    conta.Creditar(valor);
                else
                    conta.Debitar(valor);

                Console.WriteLine("Operação concluída.");
            } catch (SaldoInsuficienteException ex) {
                Console.WriteLine(ex.Message);
            }
        }

        static void ExcluirConta() {
            Console.WriteLine("Exclusão de conta:");
            if (contas.Count == 0) {
                Console.WriteLine("Não há contas para excluir.");
                return;
            }

            Console.Write("Número da conta: ");
            int numeroConta;
            if (!int.TryParse(Console.ReadLine(), out numeroConta) || numeroConta <= 0) {
                Console.WriteLine("Número da conta inválido.");
                return;
            }

            Conta conta = contas.FirstOrDefault(c => c.NumeroConta == numeroConta);
            if (conta == null) {
                Console.WriteLine("Conta não encontrada.");
                return;
            }

            if (conta.Saldo != 0) {
                Console.WriteLine("Não é possível excluir uma conta com saldo diferente de zero.");
                return;
            }

            contas.Remove(conta);
            Console.WriteLine("Conta excluída com sucesso.");
        }

        static void RelatoriosGerenciais() {
            Console.WriteLine("Relatórios Gerenciais:");
            if (contas.Count == 0) {
                Console.WriteLine("Não há contas para listar.");
                return;
            }

            Console.WriteLine("1 - Listar clientes com saldo negativo");
            Console.WriteLine("2 - Listar clientes com saldo acima de um determinado valor");
            Console.WriteLine("3 - Listar todas as contas");

            Console.Write("Escolha uma opção: ");
            int opcao;
            if (int.TryParse(Console.ReadLine(), out opcao)) {
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
            } else {
                Console.WriteLine("Opção inválida.");
            }
        }

        static void ListarClientesComSaldoNegativo() {
            var clientesComSaldoNegativo = contas.Where(c => c.Saldo < 0).ToList();
            if (clientesComSaldoNegativo.Count == 0) {
                Console.WriteLine("Não há clientes com saldo negativo.");
                return;
            }

            Console.WriteLine("Clientes com saldo negativo:");
            foreach (var conta in clientesComSaldoNegativo) {
                Console.WriteLine($"{conta.Nome} - Saldo: {conta.Saldo:F2}");
            }
        }

        static void ListarClientesComSaldoAcimaDe() {
            Console.Write("Digite o valor mínimo de saldo: ");
            double valorMinimo;
            if (!double.TryParse(Console.ReadLine(), out valorMinimo) || valorMinimo < 0) {
                Console.WriteLine("Valor mínimo inválido.");
                return;
            }

            var clientesComSaldoAcimaDe = contas.Where(c => c.Saldo > valorMinimo).ToList();
            if (clientesComSaldoAcimaDe.Count == 0) {
                Console.WriteLine($"Não há clientes com saldo acima de {valorMinimo:F2}.");
                return;
            }

            Console.WriteLine($"Clientes com saldo acima de {valorMinimo:F2}:");
            foreach (var conta in clientesComSaldoAcimaDe) {
                Console.WriteLine($"{conta.Nome} - Saldo: {conta.Saldo:F2}");
            }
        }

        static void ListarTodasAsContas() {
            Console.WriteLine("Todas as contas:");
            foreach (var conta in contas) {
                Console.WriteLine($"{conta.Nome} - Saldo: {conta.Saldo:F2}");
            }
        }

        static void CarregarContasDoArquivo() {
            if (File.Exists(arquivoContas)) {
                try {
                    string[] linhas = File.ReadAllLines(arquivoContas);
                    foreach (string linha in linhas) {
                        string[] partes = linha.Split(';');
                        if (partes.Length == 3) {
                            int numeroConta;
                            if (int.TryParse(partes[0], out numeroConta) && numeroConta > 0) {
                                string nome = partes[1];
                                double saldo;
                                if (double.TryParse(partes[2], out saldo) && saldo >= 0) {
                                    contas.Add(new Conta(numeroConta, nome, saldo));
                                }
                            }
                        }
                    }
                } catch (Exception ex) {
                    Console.WriteLine($"Erro ao carregar contas do arquivo: {ex.Message}");
                }
            }
        }

        static void SalvarContasNoArquivo() {
            try {
                using (StreamWriter writer = new StreamWriter(arquivoContas)) {
                    foreach (Conta conta in contas) {
                        writer.WriteLine($"{conta.NumeroConta};{conta.Nome};{conta.Saldo:F2}");
                    }
                }
                Console.WriteLine("Contas salvas com sucesso.");
            } catch (Exception ex) {
                Console.WriteLine($"Erro ao salvar contas no arquivo: {ex.Message}");
            }
        }
    }

    class Conta {
        public int NumeroConta {
            get; private set;
        }
        public string Nome {
            get; private set;
        }
        public double Saldo {
            get; private set;
        }

        public Conta(int numeroConta, string nome, double saldo) {
            NumeroConta = numeroConta;
            Nome = nome;
            Saldo = saldo;
        }

        public void Creditar(double valor) {
            Saldo += valor;
        }

        public void Debitar(double valor) {
            if (Saldo < valor) {
                throw new SaldoInsuficienteException("Saldo insuficiente para realizar o débito.");
            }
            Saldo -= valor;
        }
    }

    class SaldoInsuficienteException: Exception {
        public SaldoInsuficienteException(string message) : base(message) {
        }
    }
}
=======
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/* https://docs.google.com/document/d/1rpXTfLUYUmu3dqwO6F5dGMD_6TFgOoK13nDvsJeaulQ/edit */
namespace Gabriel_Souza_DR2_AT_CS {
    internal class Program {
        static void Main(string[] args) {

            Console.WriteLine("Bora codar");
        }
    }
}
>>>>>>> 126d92ddeb9e8b903d4f62e3176f116585e815da
