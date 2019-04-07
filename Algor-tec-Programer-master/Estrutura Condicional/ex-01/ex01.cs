using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {//ALESSANDRA FARIA ABREU
        static void Main(string[] args)
        {

            double num_um, num_dois;
            double opcao;


            Console.WriteLine("MENU ");
            Console.WriteLine("opção 1 = MEDIA");
            Console.WriteLine("opção 2 = SUBTRAÇÃO");
            Console.WriteLine("opção 3 = MULTIPLICAÇÃO");
            Console.WriteLine("opção 4 = DIVISÃO");
            Console.WriteLine("");

            Console.Write("Digite o primeiro número: ");
            num_um = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite o segundo número: ");
            num_dois = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite a sua opção: ");
            opcao = Convert.ToDouble(Console.ReadLine());


            if (opcao == 1)
            {
                Console.WriteLine("o resultado da média é: " + (num_um + num_dois) / 2);
            }

            else if ((opcao ==2) && (num_um > num_dois))
            {
                Console.WriteLine("o resultado da subtração é: " + (num_um - num_dois));
            }

            else if((opcao==2) &&(num_um<num_dois)){
            	Console.WriteLine("o resultado da subtração é: "+(num_dois-num_um));
            }

            else if (opcao == 3)
            {
                Console.WriteLine("o resultado do produto é  é: " + (num_um * num_dois));
            }

            else if (opcao == 4)
            {
                Console.WriteLine("o resultado da divisão do primeiro pelo segundo é: " + (num_um / num_dois));
            }

            else
            {
                Console.Write("o opção digitada não é válida : ");
                Console.ReadKey();
            }

            Console.Write("fim ");
            Console.ReadKey();

        }
    }
}
