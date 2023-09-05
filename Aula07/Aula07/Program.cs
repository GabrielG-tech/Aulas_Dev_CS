using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula07 {
    internal class Program {
        static void Main(string[] args) {
            Conta conta1 = new Conta(1, "LP", 1000);
            Conta conta2 = new Conta();

            Console.WriteLine(conta1.Num);
            Console.WriteLine(conta1.Nome);
            Console.WriteLine(conta1.Saldo);

            Console.WriteLine(conta2.Num);
            Console.WriteLine(conta2.Nome);
            Console.WriteLine(conta2.Saldo);
        }
    }
}
