using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP3_CS {
    public class Professor {
        public String Nome { get; set; }
        public String Telefone { get; set; }
        public String Titulação { get; set; }

        // Sobrecarga ou overload de construtor
        public Professor() { }

        public Professor(String nome, String telefone, String titulação) {
            Nome = nome;
            Telefone = telefone;
            Titulação = titulação;
        }

        // Sobrecarga de método
        //public double Soma() {
        //    return Op1 + Op2;
        //}

        //public double Soma(double op1, double op2) {
        //    return op1 + op2;
        //}

        //public double Subtracao() {
        //    return Op1 - Op2;
        //}

        //public double Subtracao(double op1, double op2) {
        //    return op1 - op2;
        //}

        //public double Multiplicacao() {
        //    return Op1 * Op2;
        //}

        //public double Multiplicacao(double op1, double op2) {
        //    return op1 * op2;
        //}

        //public double Divisao() {
        //    return Op1 / Op2;
        //}

        //public double Divisao(double op1, double op2) {
        //    return op1 / op2;
        //}

        //// Sobreescrita ou override do método ToString() da classe Object 
        //public override string ToString() {
        //    return "Op1 = " + Op1 + "\nOp2 = " + Op2;
        //}
    }
}