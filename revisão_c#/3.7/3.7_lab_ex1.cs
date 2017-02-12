//
// nome do programa: 3.3_lab_ex1.cs
//
// programadores: Alessandra Faria Abreu e Igor Santana
// data: data:11/02/2017
// entrada(s): temperatura composta por  numeros tipo double através da linha de comando 
// valor da temperatura e tipo C ou F 
// C -273 a 100   F -459 a 212
// saida(s): imprime um numero do tipo double com o valor da temperatura convertido,
// para executar  e testar digite: 
// 3.7_lab_ex1.exe 58 c
// descricao: recebe uma temperatura em numeros string através da linha de comando,
// converte para double ,armazena na variavel formato .Verifica o tipo de escala escolhido
//chama o metodo estático da escala passando a temperatura como parametro, faz os calculos da conversão °F = °C × 1, 8 + 32
//C = (°F − 32) ÷ 1, 8
//retorna o resultado para o metodo Main
//imprime o resultado na tela
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

        	double valor=0;
        	string formato;

        	valor=Convert.ToDouble(args[0]);
        	formato=args[1];

            Console.WriteLine("Desenvolvedores Alessandra Faria Abreu e Igor Santana"); //imprime o nome OBRIGATÓRIO
            if ((formato=="c")||(formato=="C"))
            {
                if ((valor>-273)&&(valor<100))
                {
                    Console.WriteLine(": {0} graus Celsius = {1} graus Fahrenheit", valor,ConvertCforF(valor));
                }
                else
                {
                    Console.WriteLine("Valor fora da escala , digite entre -273 e 100 graus C");
                }
            }
            else if ((formato=="f")||(formato=="F"))
            {
                if ((valor>-459)&&(valor<212))
                {
                    Console.WriteLine(": {0} graus Fahrenheit = {1} graus Celsius", valor,ConvertFforC(valor));
                }
                else
                {
                    Console.WriteLine("Valor fora da escala , digite entre -459 e 212 graus F");
                }
              
            }
            else
            {
                Console.WriteLine("a escala digitada não existe");
            }
        }
        static Double ConvertCforF(double valor)
        {
            double resultado = 0;
            resultado = (valor * 1.8) + 32;

            return resultado;
        }

        static Double ConvertFforC(double valor)
        {
            double resultado = 0;
            resultado = (valor - 32) + 1.8;

            return resultado;
        }
    }
}