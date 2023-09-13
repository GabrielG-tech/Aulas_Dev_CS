using System;

namespace Lista4_Ex12 {
    internal class Program {
        static void Main(string[] args) {
            double[,] notas = { { 5, 7, 4 }, { 5, 6, 7 }, { 3, 5, 2 }, { 4, 5, 6 }, { 8, 9, 7 }, { 2, 6, 4 } };

            MostrarNotas(notas);
            ExibirMediaAlunos(notas);
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
            Console.WriteLine("\nMédia da turma = " + mediaTurma);
        }

        public static void ExibirMediaAlunos(double[,] notas) {
            double soma, media;

            for (int i = 0; i < notas.GetLength(0); i++) {
                soma = 0;
                for (int j = 0; j < notas.GetLength(1); j++) {
                    soma += notas[i, j];
                }
                media = soma / notas.GetLength(1);
                Console.WriteLine("Média do aluno " + (i + 1) + " = " + media);
            }
        }

        public static void MostrarNotas(double[,] notas) {

            Console.WriteLine("Notas");
            for (int i = 0; i < notas.GetLength(0); i++) {
                for (int j = 0; j < notas.GetLength(1); j++) {
                    Console.Write(notas[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }
    }
}
