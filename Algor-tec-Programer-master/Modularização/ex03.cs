using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication21
{
    class Program
    {
        public static double verifica(int numero)
        {
            double result;
            char positivo, negativo;
           
            if (numero<0)
            {
                result = -1;
            }
            else if (numero>0)
            {
                result = 1;
            }
            else
            {
                result = 0;
            }
            return (result);
           
        }

        static void Main(string[] args)
        {
            int n;
            double a;
            Console.WriteLine("digite um numero ");
            n = Convert.ToInt32(Console.ReadLine());

            a = verifica(n);
            if (a == 0)
            {
                Console.WriteLine("o numero é neutro");
            }
            else if (a == -1)
            {
                Console.WriteLine("o numero é negativo");
            }
            else
            {
                Console.WriteLine("o numero é positivo");
            }
            Console.WriteLine("fim");
            Console.ReadKey();
        }
    }
}
