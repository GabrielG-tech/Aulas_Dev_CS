﻿using System.Collections.Generic;

namespace Aula01._1 {
    public class Teste {
        public static List<Conta> MockLista(List<Conta> contas) { // Simular dados
            Conta conta = new Conta(1, "Bill", 1000);
            contas.Add(conta);
            contas.Add(new Conta(2, "Gabriel", 2000));
            contas.Add(new Conta(3, "Joao", 3000));
            return contas;
        }
    }
}
