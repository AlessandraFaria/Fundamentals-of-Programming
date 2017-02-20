//
// nome do programa: Ex34_Lab2_s117p
//
// Desenvolvedores Alessandra Faria Abreu (573831) e Matheus Cunha Nicoloni (555083)
// data: data:20/02/2017
// entrada(s): temperatura composta por  numeros tipo double através da linha de comando 
// valor da temperatura e tipo C ou F 
// C -273 a 100   F -459 a 212
// saida(s): imprime um numero do tipo double com o valor da temperatura convertido,
// para executar  e testar digite: 
//Ex34_Lab2_s117p (valor da temperatura) [escala (c ou f) ]
// descricao: recebe uma temperatura em numeros string através da linha de comando,
// converte para double ,armazena na variavel formato .Verifica o tipo de escala escolhido
//chama o metodo estático da escala passando a temperatura como parametro,
//dentro do metodo avalia se o valor recebido obedece as regras da escala e se obedever chama a função correspondente na classe "ConversorTemp"
//Dentro das funções da classe ConversorTemp é feito os calculos da conversão
//°F = °C × 1, 8 + 32
//C = (°F − 32) ÷ 1, 8
//retorna o resultado para o metodo correspondente à escala
//imprime o resultado na tela
//
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex34labex2
{
    class Menu
    {
        static ConversorTemp chamaConver;

        static void Main(string[] args)
        {
            double valor = 0;
            
            chamaConver = new ConversorTemp();

            Console.WriteLine("Desenvolvedores Alessandra Faria Abreu e Matheus Cunha"); //imprime o nome OBRIGATÓRIO
          
            Console.WriteLine("\n\t\t\t Conversor de Temperatura\t\t\t\t " +
                    "\n 1 - Converter de Celsius para Fahrenheit \t" +
                    "\n 2 - Converter de Fahrenheit para Celsius  \t" +
                    "\n 3 - Sair do programa \t" +
                    "\n \t\t\t\t\t\t\t ");
            int opcao = Convert.ToInt32(Console.ReadLine());
            while (opcao != 3)
            {
                switch (opcao)
                {
                    case 1:
                        Console.Clear();
                        Console.WriteLine("digite o valor que deseja Converter");
                        valor = Convert.ToDouble(Console.ReadLine());
                        TestaConver_c(valor);
                        break;
                    case 2:
                        Console.Clear();
                        Console.WriteLine("digite o valor que deseja Converter");
                        valor = Convert.ToDouble(Console.ReadLine());
                        TestaConver_f(valor);
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine("Opção Inválida.");
                        break;
                }
                Console.WriteLine("Desenvolvedores Alessandra Faria Abreu e Matheus Cunha");
                Console.WriteLine("\n\t\t\t Conversor de Temperatura\t\t\t\t " +
                   "\n 1 - Converter de Celsius para Fahrenheit \t" +
                   "\n 2 - Converter de Fahrenheit para Celsius  \t" +
                   "\n 3 - Sair do programa \t" +
                   "\n \t\t\t\t\t\t\t ");
                opcao = Convert.ToInt32(Console.ReadLine());
            }
            
        }
        static void TestaConver_c(double valor)
        {
            if ((valor > -273) && (valor < 100))
            {
                double resultado= chamaConver.CelsiusFahrenheit(valor);
                Console.WriteLine(": {0} graus Celsius = {1} graus Fahrenheit", valor, resultado);
            }
            else
            {
                Console.WriteLine("Valor fora da escala , digite entre -273 e 100 graus C");
            }
        }
        static void TestaConver_f(double valor)
        {
            if ((valor > -459) && (valor < 212))
            {
                double resultado = chamaConver.FahrenheitCelsius(valor);
                Console.WriteLine(": {0} graus Fahrenheit = {1} graus Celsius", valor, resultado);
            }
            else
            {
                Console.WriteLine("Valor fora da escala , digite entre -459 e 212 graus F");
            }
        }
    }

    public class ConversorTemp
    {
        public Double CelsiusFahrenheit(double tempCelsius)
        {
            return (tempCelsius * 9 / 5) + 32;
        }
        public Double FahrenheitCelsius(double tempFahrenheit)
        {
             return (tempFahrenheit - 32) + 1.8;
        }
    }
}
