using static Banco.Util;
using static Banco.CRUDdb;

namespace Banco {
    public class CRUD {

        public static void IncluirConta() {

            string nome = LerNome();
            double saldo = LerSaldo();
            Incluir(new Conta(0, nome, saldo));
        }

        public static void AlterarConta() {

            int id = LerId();
            Conta conta = ConsultarConta(id);
            if (conta == null) {
                Console.WriteLine("Erro: conta não existe");
                return;
            }
            AlterarSaldo(conta);
            Alterar(conta);
        }

        public static void AlterarSaldo(Conta conta) {

            conta.Saldo = 0;
        }

        public static void ExcluirConta() {

            int id = LerId();
            Conta conta = ConsultarConta(id);
            if (conta == null) {
                Console.WriteLine("Erro: conta não existe");
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
                Console.WriteLine("Erro: conta não existe");
                return;
            }
            Console.WriteLine(conta);
        }
    }
}
