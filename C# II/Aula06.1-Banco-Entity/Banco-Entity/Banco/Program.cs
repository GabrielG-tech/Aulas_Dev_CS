using System;
using static Banco.CRUD;
using static Banco.CRUDdb;
using System.Data.SqlClient;

namespace Banco {
    public class Program {

        static void Main(string[] args) {

            ExibirContas();
            IncluirConta();
            //ExcluirConta();
            //AlterarConta();
            ExibirContas();
        }
    }
}