namespace CalculadoraOO {
    class Calculadora : ICalculadora {
        public double Op1 { get; set; }
        public double Op2 { get; set; }

        // Sobrecarga ou overload de construtor
        public Calculadora() { }

        public Calculadora(double op1, double op2) {
            Op1 = op1;
            Op2 = op2;
        }
        // Sobrecarga de método
        public double Soma() {
            return Op1 + Op2;
        }
        
        public double Soma(double op1, double op2) {
            return op1 + op2;
        }
        
        public double Subtracao() {
            return Op1 - Op2;
        }
        
        public double Subtracao(double op1, double op2) {
            return op1 - op2;
        }
        
        public double Multiplicacao() {
            return Op1 * Op2;
        }
        
        public double Multiplicacao(double op1, double op2) {
            return op1 * op2;
        }
        
        public double Divisao() {
            return Op1 / Op2;
        }
        
        public double Divisao(double op1, double op2) {
            return op1 / op2;
        }

        // Sobreescrita ou override do método ToString() da classe Object 
        public override string ToString() {
            return "Op1 = " + Op1 + "\nOp2 = " + Op2;
        }
    }
}