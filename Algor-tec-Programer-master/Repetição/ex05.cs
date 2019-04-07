using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication15
{
    class Program
    {//Alessandra Faria
        static void Main(string[] args)
        {
            double op;
            double nota1,nota2,nota3,media=0,peso1,peso2,peso3;

            Console.WriteLine("Menu de opções");
            Console.WriteLine("1 média aritimética");
            Console.WriteLine("2 média ponderada");       
            Console.WriteLine("sair");
            op = Convert.ToDouble(Console.ReadLine());
           

           if (op==1)
            {
                Console.WriteLine("digite a primeira nota");
                nota1 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("digite a segunda nota");
                nota2 = Convert.ToDouble(Console.ReadLine());

                media = (nota1+nota2)/2;
                Console.WriteLine("o resultado da opção escolhida é "+media);
            }
           else if (op==2)
            {
                Console.WriteLine("digite a primeira nota");
                nota1 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("digite o peso da nota");
                peso1 = Convert.ToDouble(Console.ReadLine());
          
                Console.WriteLine("digite a segunda nota");
                nota2 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("digite o peso da nota");
                peso2 = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("digite a terceita nota");
                nota3 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("digite o peso da nota nota");
                peso3 = Convert.ToDouble(Console.ReadLine());

                media = ((nota1*peso1) + (nota2*peso2)+(nota3*peso3)) / (peso1+peso2+peso3);
                Console.WriteLine("o resultado da opção escolhida é " + media);
            }
           else if (op==3)
            {
                Console.WriteLine("saída");
                Console.ReadKey();
            }
           else
            {
                Console.WriteLine("a opção digitada não existe");
            }
            Console.WriteLine("fim");
            Console.ReadKey();

        }
    }
}
