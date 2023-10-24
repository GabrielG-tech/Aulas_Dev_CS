using System;
using static Aula04._1.CRUD;
using static Aula04._1.Teste;
using System.Data.SqlClient;
using static System.Net.Mime.MediaTypeNames;
using System.Runtime.Remoting.Contexts;
namespace Aula04._1 {
    namespace Banco {
        public class Program {

            const string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=BancoAT;Integrated Security=True;Connect Timeout=30;Encrypt=False"; // Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False
            static void Main(string[] args) {
                ConsultarContas();
            }

            public static void ConsultarContas() {
                string sql = "SELECT * FROM contas";

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
                            Console.WriteLine(conta);
                        }

                        dr.Close();
                    } catch (Exception ex) {

                    }
                }
            }
        }
    }
}