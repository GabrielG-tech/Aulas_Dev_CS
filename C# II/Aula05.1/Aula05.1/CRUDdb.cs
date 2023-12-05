using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace Aula05._1 {
    public class CRUDdb {

        const string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=BancoAT;Integrated Security=True;Connect Timeout=30;Encrypt=False;";

        public static void Incluir(Conta conta) {
            string sql = "INSERT INTO contas (nome, saldo) VALUES (@nome, @saldo)";

            using (var conn = new SqlConnection(connectionString)) {
                try {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    cmd.Parameters.Add(new SqlParameter("@nome", conta.Nome));
                    cmd.Parameters.Add(new SqlParameter("@saldo", conta.Saldo));
                    cmd.ExecuteNonQuery();
                } catch (SqlException ex) {
                    Console.WriteLine(ex.Message);
                } 
            }
        }

        public static List<Conta> ConsultarContas() {
            string sql = "SELECT * FROM contas";
            List<Conta> contas = new List<Conta>();

            using (SqlConnection conn = new SqlConnection(connectionString)) {
                try {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    SqlDataReader dr = cmd.ExecuteReader();

                    while (dr.Read()) {
                        int id = int.Parse(dr["Id"].ToString());
                        string nome = dr["Nome"].ToString();
                        double saldo = double.Parse(dr["Saldo"].ToString());
                        Conta conta = new Conta(id, nome, saldo);
                        contas.Add(conta);
                    }
                    dr.Close();
                } catch (Exception ex) {
                    Console.WriteLine("Erro: Problema no Banco de Dados " + ex.Message);
                }
            }
            return contas;
        }
    }
}
