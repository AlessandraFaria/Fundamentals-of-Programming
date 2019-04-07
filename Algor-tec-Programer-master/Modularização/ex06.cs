using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        public static double salarioconta(double sa,double ini,double soma)
        {
            double conta,media=0, salame=0,per=0,novo=0;
            double salmax =double.MaxValue;
            salmax = sa;
            for (conta = 0; conta < ini; conta++)
            {
                
                media = soma / ini;
                Console.WriteLine("a media dos salários é : " + media);
                Console.WriteLine("o maior salário é " + salmax);

                if (sa<320)
                {
                    salame++;
                }
                per = salame / ini;
                Console.WriteLine("o percentual de pessoas con salário menor que 320 é"+per);
             

            }
            return (soma);
        }

        public static double filhinhos(double ini,double fi)
        {
            double conta, result = 0, novo = 0, nu;
            for (conta = 0; conta < ini; conta++)
            {

                nu = fi + novo;
                result = nu / ini;
                Console.WriteLine("a media dos filhos é : " + result);
                novo = fi;
            }
            return (result);

        }


        static void Main(string[] args)
        {
            double salario, filhos,inicio=0,soma=0;
            Console.WriteLine("digite o valor do salário");
            salario = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("digite a quantidade de filhos");
            filhos = Convert.ToDouble(Console.ReadLine());

            while (salario>0)
            {
                inicio++;
                soma = soma + salario;


                Console.WriteLine(salarioconta(salario,inicio,soma));
                Console.WriteLine(filhinhos( inicio,filhos));

                Console.WriteLine("--------------------------------");
                Console.WriteLine("digite o valor do salário");
                salario = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("digite a quantidade de filhos");
                filhos = Convert.ToDouble(Console.ReadLine());

            }
        }
    }
}
