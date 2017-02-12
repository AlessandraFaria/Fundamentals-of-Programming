//
// nome do programa: 3.5_lab_ex1.cs
//
// programadores: Alessandra Faria Abreu e Igor Santana
// data: data:09/02/2017
// entrada(s): 1- um dos numeros da operação numero tipo double, simbolo do operando,
//segundo numero da operaçãp recebidos através da linha de comando 
// saida(s):resultado da operação , numero do tipo double
// para executar  e testar digite: 
// 3.5_lab_ex1.exe 3 2.5 x 3
// descricao: recebe os dois numeros da operação pela linha de comando ,convert e os armazena em duas variaveis do tipo double ,
// recebe o valor do operando o armazena em uma variavel e a usa como parametro para chamar o metodo estático da operação escolhida
//dentro do metodo faz os calculos
//soma , multiplicação , subtração e divisão
//eimprime o resultado 
//
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex34labex1
{
    class Program
    {
        static void Main(string[] args)
        {

            double valor_1 = 0;
            double valor_2 = 0;
            string operando=null;

            operando = args[1];
                valor_1 = Convert.ToDouble(args[0]);
                valor_2 = Convert.ToDouble(args[2]);
           

            Console.WriteLine("Desenvolvedores Alessandra Faria Abreu e Igor Santana"); //imprime o nome OBRIGATÓRIO

            if (operando=="x")
            {
                Multiplica(valor_1, valor_2);
            }
            else if (operando == "/")
            {
                Divisao(valor_1, valor_2);
            }
            else if (operando == "-")
            {
                Subtracao(valor_1, valor_2);
            }
            else if (operando == "+")
            {
                Soma(valor_1, valor_2);
            }
            else
            {
                Console.WriteLine("o operando escolhido não é válido");
            }

        }

        static void Multiplica(double valor_1, double valor_2)
        {
            double resultado = 0;
            resultado = valor_1 * valor_2;
            Console.WriteLine(valor_1 + " X " + valor_2+" = " + resultado);
        }

        static void Divisao(double valor_1, double valor_2)
        {
            double resultado = 0;
            resultado = valor_1 / valor_2;
            Console.WriteLine(valor_1 + " / " + valor_2 + " = " + resultado);
        }

        static void Subtracao(double valor_1, double valor_2)
        {
            double resultado = 0;
            resultado = valor_1 - valor_2;
            Console.WriteLine(valor_1 + " - " + valor_2 + " = " + resultado);
        }

        static void Soma(double valor_1, double valor_2)
        {
            double resultado = 0;
            resultado = valor_1 + valor_2;
            Console.WriteLine(valor_1 + " + " + valor_2 + " = " + resultado);
        }
    }
}