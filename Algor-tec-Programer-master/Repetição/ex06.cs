using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication17
{
    class Program
    {
        static void Main(string[] args)
        {
            double salario, ferias, meses, dec;
            int opcao;

            Console.WriteLine("Menu de opçãoes:");
            Console.WriteLine("1-Novo salário");
            Console.WriteLine("2-Férias");
            Console.WriteLine("3-Décimo terceiro");
            Console.WriteLine("4-Sair");

            
            
                Console.WriteLine("Difite uma opção");
                opcao = Convert.ToInt32(Console.ReadLine());

            while (opcao != 'f')
            {
                Console.WriteLine("Difite o salário do funcionario");
                salario = Convert.ToInt32(Console.ReadLine());

                if (opcao == 1)
                {

                    if (salario < 210)
                    {
                        salario = salario + (salario * 0.15);
                    }
                    else if (salario < 600)
                    {
                        salario = salario + (salario * 0.1);
                    }

                    else
                    {
                        salario = salario + (salario * 0.05);
                    }
                    Console.WriteLine("O novo salário é : " + salario);
                }

                else if (opcao == 2)
                {
                    ferias = salario + (salario / 3);
                    Console.WriteLine("O valor das férias do funcionário é :" + ferias);
                }

                else if (opcao == 3)
                {
                    Console.WriteLine("digite o numero de meses trabalhados");
                    meses = Convert.ToDouble(Console.ReadLine());
                    if (meses < 12)
                    {
                        dec = salario * (meses / 12);
                        Console.WriteLine("O valor do décimo terceiro é : " + dec);
                    }

                }


            }
            Console.WriteLine("fim");
            Console.ReadKey();
        }
    }
}
