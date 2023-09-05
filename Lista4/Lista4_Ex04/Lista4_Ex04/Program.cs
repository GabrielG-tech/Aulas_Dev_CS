using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista4_Ex04 {
    internal class Program {
        static void Main(string[] args) {
            const int TAM = 20;
            const int FIM = 0;
            int[] vet = new int[TAM];
            int num, tamLog = 0; // Escopo local

            num = LerNumero();
            while (num != FIM) {
                vet[tamLog] = num;
                tamLog++;
                num = LerNumero();
            }
            MostrarVetor();
        }

        public static int LerNumero() {
            int num; // Escopo local

            Console.WriteLine("Entre com um número: ");
            num = int.Parse(Console.ReadLine());
            return num;
        }

        public static ? MostrarVetor(int tamLog, vet[]) {
            for (int i = 0; i < tamLog; i++) {
                Console.WriteLine(vet[i]);
            }
        }
    }
}
