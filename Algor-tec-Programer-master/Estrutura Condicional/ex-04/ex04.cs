using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
    class Program
    {
        //ALESSANDRA FARIA ABREU
        static void Main(string[] args)
        {
            double idade, peso;

            Console.WriteLine("Digite a sua Idade");
            idade = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite o seu peso atual");
            peso = Convert.ToDouble(Console.ReadLine());

            if (peso<=60)
            {
                if (idade<=20)
                {
                    Console.WriteLine("Você pertence ao grupo de risco N 9");
                }
                else if (idade<=50)
                {

                    Console.WriteLine("Você pertence ao grupo de risco N 6");
                }
                else
                {
                    Console.WriteLine("Você pertence ao grupo de risco N 3");
                }
            }

            else if (peso<=90)
            {
                if (idade <= 20)
                {
                    Console.WriteLine("Você pertence ao grupo de risco N 8");
                }
                else if (idade <= 50)
                {

                    Console.WriteLine("Você pertence ao grupo de risco N 5");
                }
                else
                {
                    Console.WriteLine("Você pertence ao grupo de risco N 2");
                }
            }

            else
            {
                if (idade <= 20)
                {
                    Console.WriteLine("Você pertence ao grupo de risco N 7");
                }
                else if (idade <= 50)
                {

                    Console.WriteLine("Você pertence ao grupo de risco N 4");
                }
                else
                {
                    Console.WriteLine("Você pertence ao grupo de risco N 1");
                }
            }
            Console.WriteLine("fim");
            Console.ReadKey();            

        }
    }
}
