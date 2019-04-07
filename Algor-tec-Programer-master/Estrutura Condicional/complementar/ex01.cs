using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication8
{
    class Program
    {//ALESSANDRA FARIA ABREU
        static void Main(string[] args)
        {
            double nota1, nota2, nota3, nota4;
            double media;

            Console.Write("Digite a primeira nota: ");
            nota1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite a segunda nota: ");
            nota2 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite a terceira nota: ");
            nota3 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite a quarta nota: ");
            nota4 = Convert.ToDouble(Console.ReadLine());

            media = (nota1=nota2+nota3+nota4)/4;

            if (media<7)
            {
                Console.Write("Aluno REPROVADO");
            }
            else
            {
                Console.Write("Aluno APROVADO");
            }
            Console.Write("fim");
            Console.ReadKey();
        }
    }
}
