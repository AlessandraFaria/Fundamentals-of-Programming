using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication5
{
    class Program
    {
        static void Main(string[] args)
        {
            //ALESSANDRA FARIA ABREU
            
            double id, quant;
            double prec , precfinal;


            Console.WriteLine("Digite a quantidade de produto escolhido");
            quant = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite o preço unitário do produto");
            id = Convert.ToDouble(Console.ReadLine());

            // prefinal = id / quant;

            if (id <= 10)
            {
                prec = 10*quant;
                if (prec < 250)
                {
                    precfinal = prec - (prec * 0.05) / 100;
                    Console.WriteLine("O preço final da nota é :" + precfinal);
                }
                else if (prec<500) {
                    precfinal = prec - (prec * 0.1) / 100;
                    Console.WriteLine("O preço final da nota é :" + precfinal);
                }
                else
                {
                    precfinal = prec - (prec * 0.15) / 100;
                    Console.WriteLine("O preço final da nota é :" + precfinal);
                }
                
            }
            else if (id<=20)
            {
                prec = 15 * quant;
                if (prec < 250)
                {
                    precfinal = prec - (prec * 0.05) / 100;
                    Console.WriteLine("O preço final da nota é :" + precfinal);
                }
                else if (prec < 500)
                {
                    precfinal = prec - (prec * 0.1) / 100;
                    Console.WriteLine("O preço final da nota é :" + precfinal);
                }
                else
                {
                    precfinal = prec - (prec * 0.15) / 100;
                    Console.WriteLine("O preço final da nota é :" + precfinal);
                }

            }
            else if(id<=30){
                prec = 20 * quant;
                if (prec < 250)
                {
                    precfinal = prec - (prec * 0.05) / 100;
                    Console.WriteLine("O preço final da nota é :" + precfinal);
                }
                else if (prec < 500)
                {
                    precfinal = prec - (prec * 0.1) / 100;
                    Console.WriteLine("O preço final da nota é :" + precfinal);
                }
                else
                {
                    precfinal = prec - (prec * 0.15) / 100;
                    Console.WriteLine("O preço final da nota é :" + precfinal);
                }
            }
            else if(id<=40)
            {
                prec = 30 * quant;
                if (prec < 250)
                {
                    precfinal = prec - (prec * 0.05) / 100;
                    Console.WriteLine("O preço final da nota é :" + precfinal);
                }
                else if (prec < 500)
                {
                    precfinal = prec - (prec * 0.1) / 100;
                    Console.WriteLine("O preço final da nota é :" + precfinal);
                }
                else
                {
                    precfinal = prec - (prec * 0.15) / 100;
                    Console.WriteLine("O preço final da nota é :" + precfinal);
                }
            }

            Console.WriteLine("fim");
            Console.ReadKey();

        }
    }
}
