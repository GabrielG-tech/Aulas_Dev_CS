using System;
using System.Collections.Generic;
using static Gabriel_Souza_DR2_AT_CS.Utils;
using static Gabriel_Souza_DR2_AT_CS.CRUD;

namespace Gabriel_Souza_DR2_AT_CS {
    // Obs: Para rodar o código em outro PC pode ser necessario mudar o caminho de "DIRETORIO" em "Utils".
    class Program {
        static void Main(string[] args) {
            bool sairDoPrograma = false;
            List<Conta> contas = new List<Conta>();
            LerContasDoArquivo(contas);

            while (!sairDoPrograma) {
                ExibirMenu();
                int escolha = ValidarOpcao();
                sairDoPrograma = ProcessarEscolha(escolha, contas, ref sairDoPrograma);
            }
        }

        static bool ProcessarEscolha(int escolha, List<Conta> contas, ref bool sairDoPrograma) {
            switch (escolha) {
                case 1:
                    IncluirConta(contas);
                    break;
                case 2:
                    AlterarSaldo(contas);
                    break;
                case 3:
                    ExcluirConta(contas);
                    break;
                case 4:
                    GerarRelatorios(contas);
                    break;
                case 5:
                    GravarContasNoArquivo(contas);
                    sairDoPrograma = true;
                    break;
                default:
                    Console.WriteLine("Opção inválida.");
                    break;
            }
            return sairDoPrograma;
        }
    }
}
