using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP3_CS {
    /*
     1. Faça um programa que crie três classes: Aluno, Professor e Funcionário. A classe Aluno tem como atributos nome, telefone e matrícula, a classe Professor tem como atributos nome, telefone e titulação e a classe Funcionário tem como atributos nome, telefone e cargo. As classes devem ter sobrecarga de construtor e uma sobrescrita para exibir as suas informações, além dos gets e sets. Instancie três objetos, um de cada cada classe, inicialize os seus atributos com as informações necessárias e exiba as informações do objeto utilizando a sobrescrita implementada nas classes.

    Obs: utilizar métodos e passagem de parâmetros para melhor organizar o código.
     */
    internal class Program {
        static void Main(string[] args) {
            Aluno aluno1 = new Aluno("Pedro", "(21)98765-4321", "12345678");
            Professor professor1 = new Professor("Lucas", "(21)98765-4321", "JavaScript");
            Funcionario funcionario1 = new Funcionario("João", "(21)98765-4321", "Zelador");

            Console.WriteLine(aluno1.ToString());
            Console.WriteLine(professor1);
            Console.WriteLine(funcionario1);

            mostrarDados(aluno1);
        }
        static void mostrarDados(Aluno aluno) {
            Console.WriteLine($"Nome: {aluno.Nome}\nTelefone: {aluno.Telefone}\nMatricula: {aluno.Matricula}\n");
        }
    }
}
