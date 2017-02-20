/*
nome do programa: Ex33_Lab2_s117p.cs
Desenvolvedores Alessandra Faria Abreu (573831) e Matheus Cunha Nicoloni (555083)
data: 19/02/2017
entrada(s): 1 números inteiro através da linha de comando; 
um numero qualquer
saída(s): imprime o resultado da fatoração do número que foi digitado
para executar  e testar digite: 
Ex33_Lab2_s117p.exe 3
descrição: recebe 1 número inteiro através da linha de comando,
armazena em um vetor chamado args e chama um método que está instanciado na classe Fatorial,
onde ele irá fazer todo o cálculo do fatorial até o seu fim
que recebe este número inteiro, e retorna o fatorial do mesmo
*/

using System;
using System.Text;

namespace Ex33_Lab2_s117p
{
    class Fatorial
    {
        // atributos
        private int atrFator;
        private double atrResultado;

        // métodos
        public Fatorial(int fator)
        {
            this.atrFator = fator;
            this.atrResultado = 1;
        }

        public void mtdFatorar()
        {
            Console.WriteLine("O fatorial de " + atrFator + " é igual á ");
            Console.WriteLine();

            for (double i = 1; i <= this.atrFator; this.atrFator--)
            {
                Console.Write(this.atrResultado + " * " + (this.atrFator) + " = ");
                this.atrResultado = this.atrFator * this.atrResultado;
                Console.WriteLine(this.atrResultado);
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            int mainFatorar;

            Console.WriteLine();
            Console.WriteLine("\nPrograma Ex33_Lab2_s117p.exe");
            Console.WriteLine();
            Console.WriteLine("Alunos: " + "\nAlessandra Faria - 573831 \nMatheus Cunha Nicolini - 555083");
            Console.WriteLine();

            mainFatorar = int.Parse(args[0]);

            Fatorial vetor = new Fatorial(mainFatorar);

            vetor.mtdFatorar();
        }
    }
}