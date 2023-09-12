using System;

namespace CalculadoraOO {
    internal class Program {
        static void Main(string[] args) {
            ICalculadora calc = new ICalculadora(5, 3);

            Console.WriteLine(calc); // Console.WriteLine(calc.ToString());
            Console.WriteLine("Soma          = " + calc.Soma(7, 5));
            Console.WriteLine("Subtração     = " + calc.Subtracao(9, 5));
            Console.WriteLine("Multiplicação = " + calc.Multiplicacao(2, 5));
            Console.WriteLine("Divisão       = " + calc.Divisao(7, 3));

            // Pascal case - SomarDoisNumeros() - C#
            // Camel case - somarDoisNumeros() - Java
            // Snake case - somar_dois_numeros() - Python
        }
    }
}
