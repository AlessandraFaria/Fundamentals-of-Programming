using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        public static double conta(double ini,double nume)
        { double i,deno,based,conta,soma=0; 
            for (i=0; i<ini; i++)
            {
                deno = Math.Pow(nume,2)+1;
                based = nume + 3;
                conta = deno / based;
                soma = soma + conta;

            }
            return(soma);
        }


        static void Main(string[] args)
        {
            double n,inicio=0;
            Console.WriteLine("digite o numero de parcelas");
            n = Convert.ToDouble(Console.ReadLine());
            while (n>0)
            {
                inicio++;
                Console.WriteLine("o resultado é " + conta(inicio, n));
                Console.WriteLine("digite o numero de parcelas");
                n = Convert.ToDouble(Console.ReadLine());
            }
            
        }
    }
}
