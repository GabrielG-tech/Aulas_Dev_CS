using System;
using System.Collections.Generic;

using static Aula03._1_Banco.CRUD;
using static Aula03._1_Banco.Teste;

namespace Aula03._1_Banco {
    public class Program {
        static void Main(string[] args) {
            List<Conta> contas = new List<Conta>();

            contas = MockLista(contas); // LerContas();
            IncluirConta(contas);
            ExibirContas(contas);
        }

    }
}
