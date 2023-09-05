using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista4_Ex04 {
    internal class Program {
        static void Main(string[] args) {
            const int TAM = 20;
            int[] vet = new int[TAM];
            int tamLog = 0; // Escopo local

            LerNumerosNoVetor(vet, ref tamLog);
            MostrarVetor(vet, tamLog);
            double media = CalcularMedia(vet, tamLog);
            Console.Write("Média = " + media);
            MostraNumMaiorIgualMed(vet, tamLog, media);
        }
        public static int[] LerNumerosNoVetor(int[] vet, ref int talLog) {
            const int FIM = 0;
            int num, tamLog = 0;

            num = LerNumero();
            while (num != FIM) {
                vet[tamLog] = num;
                tamLog++;
                num = LerNumero();
            }
        }

        public static int MostraNumMaiorIgualMed(int[] vet, int tamLog, double media) {
            
            for (int i = 0; i < tamLog; i++) {
                if (vet[i] >= media) {
                    Console.WriteLine(vet[i] + " maior ou igual a média");
                }
            }
        }

         public static int LerNumero() {
            int num; // Escopo local

            Console.WriteLine("Entre com um número: ");
            num = int.Parse(Console.ReadLine());
            return num;
        }

        public static void MostrarVetor(int[] vet, int tl) {
            for (int i = 0; i < tl; i++) {
                Console.WriteLine(vet[i]);
            }
        }

        public static void CalcularMedia() {
            
        }
    }
}
