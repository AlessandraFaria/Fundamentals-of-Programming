using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication16
{
    class Program
    {
        static void Main(string[] args)
        {
            char letra ,r;
            double lucro = 0, conta = 0, precom, preven, lucromil = 0, lucroduo = 0, lucrototal=0 ;
         

            Console.WriteLine("digite r para finalizar");
            Console.WriteLine("digiteo código da ação ");
            letra = Convert.ToChar(Console.ReadLine());


            while (letra!='f')
            {
                Console.WriteLine("digite o valor do preço de compra da açao");
                precom = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("digite o valor do preço de venda da ação");
                preven = Convert.ToDouble(Console.ReadLine());

                lucro = preven - precom;
                Console.WriteLine("o lucro é "+lucro);
                if (lucro>1000)
                {
                    lucromil++;
                }
                else if (lucro<200)
                {
                    lucroduo ++;
                }
                Console.WriteLine("a quantidade de ações com lucro maior que R$1000 é:  "+lucromil);
                Console.WriteLine("a quantidade de ações com lucro menor que R$200 é:  " + lucroduo);


                lucrototal = lucrototal + lucro;
                Console.WriteLine("o lucro total é  " + lucrototal);

                Console.WriteLine("digiteo código da ação ");
                letra = Convert.ToChar(Console.ReadLine());

            }


           Console.ReadKey();


        }
        
    }
}
