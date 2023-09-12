namespace ArquivoCSV {
    internal class Program {
        static void Main(string[] args) {
            LerArquivo();
        }

        public static void LerArquivo() {
            const String nomeArquivo = "turma.csv";
            //const String diretorio = "C:\\Users\\gabriel.gsouza\\Documents\\Dev_CS\\Aula15\\Aula15.2";
            const String diretorio = @"C:\Users\gabriel.gsouza\Documents\Dev_CS\Aula15\Aula15.2";

            string caminho = Path.Combine(diretorio, nomeArquivo);
            if (!File.Exists(caminho)) {
                Console.WriteLine("Erro: Arquivo não existe");
            }
            try {
                using (var arquivo = new StreamReader(caminho)) {
                    string linha = arquivo.ReadLine();
                    while (linha != null) { // Testar o final do arquivo EOF
                        string[] campos = linha.Split(';');
                        Aluno aluno = new Aluno(campos[0],
                            double.Parse(campos[1]), double.Parse(campos[2]), double.Parse(campos[1]));
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