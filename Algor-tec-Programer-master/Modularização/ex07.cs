using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class Program
    {

        public static double verificacao( double a1, double b2, double c3)
        {
            double result=0;
            if (a1<=(b2+c3))
            {
                if (b2<=(a1+c3))
                {
                    if (c3<=(b2+c3))
                    {
                        result = 1;
                    }
                }
            }
            return (result);
            
        }

        public static double tipo(double aa,double bb,double cc)
        {
            double tipo=0;
            if ((aa==bb)||(cc==bb))
            {
                tipo = 1;
            }
            else if ((aa==bb)&&(bb==aa)&&(bb==cc))
            {
                tipo = 2;
            }
            else
            {
                tipo = 3;
            }
            return (tipo);
        }


        static void Main(string[] args)
        {
            double a, b, c;
            double resultver,resulttipo;
            Console.WriteLine("digite o primeiro valor ");
            a = Convert.ToDouble(Console.ReadLine());
            if (a>0)
            {
                Console.WriteLine("digite o segundo valor ");
                b = Convert.ToDouble(Console.ReadLine());
                if (b > 0)
                {
                    Console.WriteLine("digite o terceito valor valor ");
                    c= Convert.ToDouble(Console.ReadLine());
                    resultver= verificacao( a, b,  c);
                    if (resultver == 1)
                    {
                        Console.WriteLine("é um triangulo!!");
                        resulttipo= tipo(a, b, c);
                        if (resulttipo==1)
                        {
                            Console.WriteLine("O triangulo é equilátero");
                        }
                        else if (resulttipo==2)
                        {
                            Console.WriteLine("o triangulo é isoceles ");
                        }
                        else
                        {
                            Console.WriteLine(" o triangulo é escaleno ");
                        }
                    }

                }
                else
                {
                    Console.WriteLine("os valores deve ser maiores que 0");
                }

            }
           

            Console.Write("fim");
            Console.ReadKey();
        }
    }
}
