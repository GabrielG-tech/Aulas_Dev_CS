using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista2_Ex10 {
    internal class Program {
        static void Main(string[] args) {
            // Ex 10
            int dia, mes, ano;
            // Alt + Shift + . (Edita characteres iguais)
            // Ctrl + K, Ctrl + D (Formatar código)

            Console.Write("Entre com o dia: ");
            dia = Int32.Parse(Console.ReadLine());
            Console.Write("Entre com o mes: ");
            mes = Int32.Parse(Console.ReadLine());
            Console.Write("Entre com o ano: ");
            ano = Int32.Parse(Console.ReadLine());

            switch (mes) {
                case 4:
                case 6:
                case 9:
                case 11:
                    if ((dia < 1) || (dia > 31)) {
                        Console.WriteLine("Dia inválido");
                    }
                    break;
                case 1:
                case 3:
                case 5:
                case 7:
                case 8:
                case 10:
                case 12:
                    if ((dia < 1) || (dia > 30)) {
                        Console.WriteLine("Dia inválido");
                    }
                    break;
                case 2:
                    if ((ano % 4) == 0) {
                        if ((dia < 1) || (dia > 29)) {
                            Console.WriteLine("Dia inválido");
                        }
                    } else {
                        if ((dia < 1) || (dia > 28)) {
                            Console.WriteLine("Dia inválido");
                        }
                    }
                    break;
                default:
                    Console.WriteLine("Mês inválido");
                    break;
            }
        }
    }
}