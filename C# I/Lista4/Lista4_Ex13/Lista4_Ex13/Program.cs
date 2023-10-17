using System;

namespace Lista4_Ex13 {
    internal class Program {
        static void Main(string[] args) {
            double[,] notas = { { 5, 7, 4 }, { 5, 6, 7 }, { 3, 5, 2 }, { 4, 5, 6 }, { 8, 9, 7 }, { 2, 6, 4 } };
            String[] alunos = { "Luiz", "Paulo", "Maria", "Luiza", "Felipe", "Clara"};

            MostrarNotas(alunos, notas);
            ExibirMediaAlunos(alunos, notas);
            ExibirMediaTurma(notas);
        }

        public static void ExibirMediaTurma(double[,] notas) {
            double soma = 0, mediaTurma = 0;

            for (int i = 0; i < notas.GetLength(0); i++) {
                for (int j = 0; j < notas.GetLength(1); j++) {
                    soma += notas[i, j];
                }
            }
            mediaTurma = soma / (notas.GetLength(0) * notas.GetLength(1));
            Console.WriteLine("\nMédia da turma = " + FormatarMedia(mediaTurma));
        }

        public static void ExibirMediaAlunos(String[] alunos, double[,] notas) {
            double soma, media;

            for (int i = 0; i < notas.GetLength(0); i++) {
                soma = 0;
                for (int j = 0; j < notas.GetLength(1); j++) {
                    soma += notas[i, j];
                }
                media = soma / notas.GetLength(1);
                Console.WriteLine("Média do aluno " + alunos[i] +
                    " = " + FormatarMedia(media));
            }
        }

        public static String FormatarMedia(double media) {

            media = Math.Round(media, 1);
            String mediaStr = media.ToString("#.#");
            return mediaStr;
        }

        public static void MostrarNotas(String[] alunos, double[,] notas) {

            Console.WriteLine("Notas");
            for (int i = 0; i < notas.GetLength(0); i++) {
                Console.Write(alunos[i] + " ");
                for (int j = 0; j < notas.GetLength(1); j++) {
                    Console.Write(notas[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }
    }
}
