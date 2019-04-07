using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication9
{
    class Program
    {//ALESSANDRA FARIA ABREU
        static void Main(string[] args)
        {
            double nota1, nota2 ;
            double media;

            Console.Write("Digite a primeira nota: ");
            nota1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite a segunda nota: ");
            nota2 = Convert.ToDouble(Console.ReadLine());

            media = (nota1 + nota2 ) / 2;

            if (media<4) {
                Console.WriteLine("Aluno REPROVADO");
            }

            else if (media<7)
            {
                Console.WriteLine("EXAME");
            }
            else
            {
                Console.WriteLine("Aluno APROVADO");
            }

            Console.Write("fim");
            Console.ReadKey();
        }
    }
    }


