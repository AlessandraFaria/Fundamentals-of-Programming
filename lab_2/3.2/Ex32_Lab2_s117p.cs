
//
// nome do programa: 3.2_lab_ex2.cs
//
// Desenvolvedores Alessandra Faria Abreu (573831) e Matheus Cunha Nicoloni (555083)
// data: data:17/02/2017
// entrada(s): 1- um dos numeros da opera��o numero tipo double, simbolo do operando,
//segundo numero da opera��p recebidos atrav�s da linha de comando 
// saida(s):resultado da opera��o , numero do tipo double
// para executar  e testar digite: 
// 3.2_lab_ex2.exe  (operando_1) (operador) (operando_2)
// descricao: recebe o numero do primeiro operando ,o simbolo do operador e o segundo numero que � o segundo operando
// converte os operandos para double e armazena em uma vari�vel 
//apos amarzenados os valores recebidos, o operador � avaliado e se estiver correto chama-se o metodo correspondente
//dentro dos metodos chamados � avaliado os valores e chamado as fun��es correspondentes da classe Opera��es
//os calculos s�o realzados dentro das fun��es da classe Operacao e retornados para os metodos da classe Menu.
//
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex32labex2
{
    class Menu
    {
        static Operacoes conta;

        static void Main(string[] args)
        {
            double valor_1 = 0;
            double valor_2 = 0;
            string operando = null;
           // Operacoes conta;

            operando = args[1];
            valor_1 = Convert.ToDouble(args[0]);
            valor_2 = Convert.ToDouble(args[2]);
            conta = new Operacoes();

            Console.WriteLine("Desenvolvedores Alessandra Faria Abreu (573831) e Matheus Cunha Nicoloni (555083)"); //imprime o nome OBRIGAT�RIO
            if (operando == "x")
            {
                ChamaMultiplica��o(valor_1,valor_2);
            }
            else if (operando == "/")
            {
                ChamaDivisao(valor_1, valor_2);
            }
            else if (operando == "-")
            {
                ChamaSubtracao(valor_1, valor_2);
            }
            else if (operando == "+")
            {
                ChamaSoma(valor_1, valor_2);
            }
            else
            {
                Console.WriteLine("o operando escolhido n�o � v�lido");
            }

        }
        static void ChamaMultiplica��o(double valor_1,double valor_2)
        {
            double resultado = conta.Multiplica(valor_1, valor_2);
            Console.WriteLine(valor_1 + " X " + valor_2 + " = " + resultado);
        }
        static void ChamaDivisao(double valor_1, double valor_2)
        {
            double resultado = conta.Divisao(valor_1, valor_2);
            Console.WriteLine(valor_1 + " / " + valor_2 + " = " + resultado);
        }
        static void ChamaSubtracao(double valor_1, double valor_2)
        {
            double resultado = conta.Subtracao(valor_1, valor_2);
            Console.WriteLine(valor_1 + " - " + valor_2 + " = " + resultado);
        }
        static void ChamaSoma(double valor_1, double valor_2)
        {
            double resultado = conta.Soma(valor_1, valor_2);
            Console.WriteLine(valor_1 + " + " + valor_2 + " = " + resultado);
        }
    }

    class Operacoes
    {
        private double resultado = 0;

        public double Multiplica(double valor_1, double valor_2)
        {
            resultado = valor_1 * valor_2;

            return resultado;

        }
        public double Divisao(double valor_1, double valor_2)
        {
            resultado = valor_1 / valor_2;

            return resultado;
        }
        public double Subtracao(double valor_1, double valor_2)
        {
            resultado = valor_1 - valor_2;
           
            return resultado;
        }
        public double Soma(double valor_1, double valor_2)
        {
            resultado = valor_1 + valor_2;
            
            return resultado;
        }
    }
}