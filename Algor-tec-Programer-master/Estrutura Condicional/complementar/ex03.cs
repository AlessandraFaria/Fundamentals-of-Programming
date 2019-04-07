using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication10
{
    class Program
    {//ALESSANDRA FARIA ABREU
        static void Main(string[] args)
        {
            double num1;
            double num2;
            double maior;

            Console.WriteLine("Digite o primeiro numero: ");
            num1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite o segundo numero: ");
            num2 = Convert.ToDouble(Console.ReadLine());

            if (num1>num2)
            {
                maior = num1;
                Console.WriteLine("o maior número é "+maior);
            }
            else if (num2>num1)
            {
                maior = num2;
                Console.WriteLine("o maior número é " + maior);
            }
            else
            {
                Console.WriteLine("os números são iguais ");
            }

            Console.WriteLine("fim");
            Console.ReadKey();
        }
    }
}
