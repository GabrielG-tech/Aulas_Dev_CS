using System;
using static Aula05._1.CRUD;
using System.Data.SqlClient;

namespace Aula05._1 {
    namespace Banco {
        public class Program {
            static void Main(string[] args) {

                IncluirConta();
                ExibirContas();
            }
        }
    }
}