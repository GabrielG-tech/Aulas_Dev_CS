using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista4_Ex13 {
    internal class Program {
        static void Main(string[] args) {
            double[,] notas = { { 5, 7, 4 }, { 5, 6, 7 }, { 3, 5, 2 }, { 4, 5, 6 }, { 8, 9, 7 }, { 2, 6, 4 } };
            String[] alunos = { "Luiz", "Paulo", "Maria", "Luiza", "Felipe", "Clara" };

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
            Console.WriteLine("\nMédia da turma: " + mediaTurma);
        }

        public static void ExibirMediaAlunos(double[,] notas) {
            double soma, media;

            for (int i = 0; i < notas.GetLength(0); i++) {
                soma = 0;
                for (int j = 0; j < notas.GetLength(1); j++) {
                    soma += notas[i, j];
                }
                media = soma / (notas.GetLength(1) * notas.GetLength(1));
                Console.WriteLine("Média da aluno " + (i + 1) + ": " + FormatarMedia(media));
            }
        }

        public static String FormatarMedia(double media) {
            media = Math.Round(media, 1);
            String mediaStr = media.ToString("#.#");
            return mediaStr;
        }

        public static void MostrarNotas(double[,] notas) {

            Console.WriteLine("Notas");
            for (int i = 0; i < notas.GetLength(0); i++) {
                for (int j = 0; j < notas.GetLength(1); j++) {
                    Console.WriteLine(notas[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }
    }
}