using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication13
{
    class Program
    {
        static void Main(string[] args)
        {
            double conta = 0, valorvista=0, valorprazo=0, valortotal=0, valor=0;
            string tipo;

            for (conta = 1; conta < 15; conta++)
            {
                Console.WriteLine("digite o valor da compra");
                valor = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("digite o tipo de pagamento");
                tipo = Convert.ToString(Console.ReadLine());

                if (tipo == "p")
                {
                    valorprazo = valor+valorprazo;
                    Console.WriteLine("O valor das compras a prazo é " + valorprazo);

                }
                else if (tipo=="v")
                {
                    valorvista = valor+valorvista;
                    Console.WriteLine("O valor das compras a vista é " + valorvista);
                }
                else
                {
                    Console.WriteLine("o tipo digitado não existe ");
                }


            }
            valortotal = valorprazo + valorvista;
            Console.WriteLine("o valor total é " + valortotal);
        }
    }
}
