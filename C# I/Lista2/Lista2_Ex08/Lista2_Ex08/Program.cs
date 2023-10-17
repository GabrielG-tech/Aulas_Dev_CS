using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista2_Ex08 {
    internal class Program {
        static void Main(string[] args) {
            // Ex 8
            String ip = ""; int dotCounter = 0; String loop = "";

            while (loop != "no" || loop != "n" || loop != "nao" || loop != "não") {

                // Validador de IP:
                while (dotCounter != 3) {
                    Console.Write("Entre com o IP: ");
                    ip = Console.ReadLine();
                    for (int i = 1; i <= ip.Length; i++) {
                        if (ip[i - 1] == '.') {
                            dotCounter++;
                        }
                    }
                }

                // Extrai o primeiro octeto:
                int octeto1 = Convert.ToInt32(ip.Split('.')[0]);


                if ((octeto1 >= 0) && (octeto1 <= 127)) {
                    Console.WriteLine("IP classe A");
                } else if ((octeto1 >= 128) && (octeto1 <= 191)) {
                    Console.WriteLine("IP classe B");
                } else if ((octeto1 >= 192) && (octeto1 <= 223)) {
                    Console.WriteLine("IP classe C");
                } else if ((octeto1 >= 224) && (octeto1 <= 239)) {
                    Console.WriteLine("IP classe D");
                } else if ((octeto1 >= 240) && (octeto1 <= 255)) {
                    Console.WriteLine("IP classe E");
                } else {
                    Console.WriteLine("IP inválido");
                }

                Console.Write("Deseja testar outro IP? (s/n): ");
                loop = Console.ReadLine().ToLower();
            }
        }
    }
}