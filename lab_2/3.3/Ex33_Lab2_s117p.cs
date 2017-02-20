/*
nome do programa: Ex33_Lab2_s117p.cs
Desenvolvedores Alessandra Faria Abreu (573831) e Matheus Cunha Nicoloni (555083)
data: 19/02/2017
entrada(s): 1 n�meros inteiro atrav�s da linha de comando; 
um numero qualquer
sa�da(s): imprime o resultado da fatora��o do n�mero que foi digitado
para executar  e testar digite: 
Ex33_Lab2_s117p.exe 3
descri��o: recebe 1 n�mero inteiro atrav�s da linha de comando,
armazena em um vetor chamado args e chama um m�todo que est� instanciado na classe Fatorial,
onde ele ir� fazer todo o c�lculo do fatorial at� o seu fim
que recebe este n�mero inteiro, e retorna o fatorial do mesmo
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

        // m�todos
        public Fatorial(int fator)
        {
            this.atrFator = fator;
            this.atrResultado = 1;
        }

        public void mtdFatorar()
        {
            Console.WriteLine("O fatorial de " + atrFator + " � igual � ");
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