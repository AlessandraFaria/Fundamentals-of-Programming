using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication22
{
    class Program
    {

        public static double contamedia(double ini,double n)
        {
            double conta, result = 0,novo=0 ,nu;
            for (conta=0;conta<ini;conta++)
            {
               
                nu = n + novo;
               result = nu / ini;
                
                novo = n;
            }
            Console.WriteLine("o resultado é " + result);
            return (result);
        }

        static void Main(string[] args)
        {
            double numero,inicio=1;

            Console.WriteLine("digite um numero");
            numero = Convert.ToDouble(Console.ReadLine());
            while(numero>0){
                inicio++;
                contamedia(inicio,numero);
                Console.WriteLine("digite um numero");
                numero = Convert.ToDouble(Console.ReadLine());
            }
            Console.Write("fim");
            Console.ReadKey();


        }
    }
}
