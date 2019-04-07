using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        //ALESSANDRA FARIA ABREU
        static void Main(string[] args)
        {
            double salario_antigo, salario_novo;

            Console.Write("digite o seu atual salário: ");
            salario_antigo = Convert.ToDouble(Console.ReadLine());

            salario_novo = (salario_antigo / 0.3) + salario_antigo;

            if (salario_antigo >= 500000)
            {
                Console.WriteLine("o seu novo salário é " + salario_novo);
            }
            else
            {
                Console.WriteLine("o seu salário não foi reajustado ");
            }

            Console.Write("fim");
            Console.ReadKey();



        }
    }
}
