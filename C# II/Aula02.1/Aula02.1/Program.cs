using System.Collections.Generic;
using static Aula02._1.CRUD;
using static Aula02._1.Teste;

namespace Aula02._1 {
    public class Program {
        static void Main(string[] args) {
            List<Conta> contas = new List<Conta>();

            contas = MockLista(contas); // LerContas()
            IncluirConta(contas);
            ExibirContas(contas);
        }
    }
}
