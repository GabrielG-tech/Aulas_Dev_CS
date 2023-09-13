using System;

namespace ArquivoCSV {
    internal class Program {
        static void Main(string[] args) {
            LerArquivo();
        }

        public static void LerArquivo() {
            const String NOME_ARQ = "turma.csv";
            // Casa:
            //const String DIR = @"C:\Users\Asus\Documents\Infnet_Bloco-BackEnd\C#\Aulas_Dev_CS\Aula15\Aula15.2";
            // Faculdade:
            const String DIR = @"C:\Users\gabriel.gsouza\Documents\Dev_CS\Aula15\Aula15.2";

            string caminho = Path.Combine(DIR, NOME_ARQ);
            if (!File.Exists(caminho)) {
                Console.WriteLine("Erro: Arquivo não existe");
            }
            try {
                using (var arquivo = new StreamReader(caminho)) { // Abertura do arquivo
                    string linha = arquivo.ReadLine();
                    while (linha != null) { // Testar o final do arquivo EOF
                        string[] campos = linha.Split(';');
                        Aluno aluno = new Aluno(campos[0],
                            double.Parse(campos[1]), double.Parse(campos[2]), double.Parse(campos[3]));
                        Console.WriteLine(aluno);
                        linha = arquivo.ReadLine();
                    }
                }
            } catch (Exception ex) {
                Console.WriteLine(ex.Message);
            }
        }
    }
}