using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class Program
    {
        static void Main(string[] args)
        {

            double cus_fab;
            double por_dist;
            double por_impo;

            Console.Write("digite o custo de fabrica do carro escolhido: ");
            cus_fab = Convert.ToDouble(Console.ReadLine());

            if (cus_fab <= 12000)
            {
                por_dist = (cus_fab*0.05)/100;
                Console.WriteLine("o preço de consumidor do carro é: " +( cus_fab+por_dist));
            }
            else if (cus_fab<=25000)
            {
                por_dist = (cus_fab * 0.1) / 100;
                por_impo = (cus_fab * 0.15) / 100;
                Console.WriteLine("o preço de consumidor do carro é: " + (cus_fab + por_dist+por_impo));
            }
            else
            {
                por_dist = (cus_fab * 0.15) / 100;
                por_impo = (cus_fab * 0.2) / 100;
                Console.WriteLine("o preço de consumidor do carro é: " + (cus_fab + por_dist + por_impo));

            }
            Console.WriteLine("fim");
            Console.ReadKey();
        }
    }
}
