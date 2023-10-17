using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraOO { 
    public interface ICalculadora {

        double Soma();
        double Soma(double a, double b);
        double Subtracao();
        double Subtracao(double a, double b);
        double Multiplicacao();
        double Multiplicacao(double a, double b);
        double Divisao();
        double Divisao(double a, double b);

    }
}
