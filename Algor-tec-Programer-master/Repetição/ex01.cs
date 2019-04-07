using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication12
{
    class Program
    {
        static void Main(string[] args)
        {
            double conta=0, idade,novos=0,velhos=0, per = 0;
           

            for (conta=1; conta<15;conta++)
            {
                Console.WriteLine("Digite a idade");
                idade = Convert.ToDouble(Console.ReadLine());

                if (idade <= 15)
                {
                    per++;
                    Console.WriteLine("faixa etaria 1");
                    novos = idade + novos;
                }
                else if (idade<=31)
                {
                    Console.WriteLine("faixa etaria 2");
                }
                else if (idade <= 45)
                {
                    Console.WriteLine("faixa etaria 3");
                }
                else { 
                    per++;
                    Console.WriteLine("faixa etaria 5 ");
                    velhos = idade + velhos;
                }
            }

            Console.WriteLine("a percentagem da maior e da menor faixa etaria é " + (novos + velhos) / per);

            Console.Write("fim");
            Console.ReadKey();
        }
    }
}
