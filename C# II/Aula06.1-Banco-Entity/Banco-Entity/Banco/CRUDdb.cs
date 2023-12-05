namespace Banco {
    public class CRUDdb {
        
        public static void Incluir(Conta conta) {

            using (var db = new BancoDbContext()) {
                db.Contas.Add(conta);
                db.SaveChanges();
            }
        }

        public static void Alterar(Conta conta) {

            using (var db = new BancoDbContext()) {
                db.Contas.Update(conta);
                db.SaveChanges();
            }
        }

        public static void Excluir(Conta conta) {
            
            using (var db = new BancoDbContext()) {
                db.Contas.Remove(conta);
                db.SaveChanges();
            }
        }

        public static Conta ConsultarConta(int numConta) {

            using (var db = new BancoDbContext()) {
                Conta conta = db.Contas.Find(numConta);
                return conta;
            }
        }

        public static List<Conta> ConsultarContas() {

            using (var db = new BancoDbContext()) {
                List<Conta> contas = db.Contas.ToList();
                return contas;
            }
        }
    }
}
