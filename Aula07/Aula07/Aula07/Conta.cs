using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula07 {
    internal class Conta {
        //private int num;
        //private String nome;
        //private double saldo;
        //public void setNum(int num) {
        //    this.num = num;
        //}
        //public int getNum() {
        //    return num;
        //}
        //public void setNome(String nome) {
        //    this.nome = nome;
        //}
        //public String getNome() {
        //    return nome;
        //}
        //public void setSaldo(int saldo) {
        //    this.saldo = saldo;
        //}
        //public double getSaldo() {
        //    return saldo;
        //}
        //         ou

        public int Num { get; set; }
        public string Nome { get; set; }
        public double Saldo { get; set; }

        public Conta() {
            Num = 0;
            Nome = string.Empty; // ou ""
            Saldo = 100;
        }

        public Conta(int num, string nome, double saldo) {
            Num = num;
            Nome = nome;
            Saldo = saldo;
        }
    }
}
