using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication6
{
    class Program
    {//ALESSANDRA FARIA ABREU
        static void Main(string[] args)
        {
                double preco;
                double categoria; 
                string situacao;
                double aumento;
                double imposto;
                double novpreco;

            Console.WriteLine("Digite o preço do produto:  ");
            preco = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite a categoria do produto (1=> LIMPEZA, 2=>ALIMENTAÇÃO, 3=>VESTUÁRIO)");
            categoria = Convert.ToDouble(Console.ReadLine());

            aumento = Convert.ToDouble(Console.ReadLine());

            imposto = Convert.ToDouble(Console.ReadLine());

            novpreco = Convert.ToDouble(Console.ReadLine());
            novpreco = ((preco-imposto)+aumento);


            if (preco <= 25)
            {
                if (categoria == 1) {

                    aumento =( preco * 0.05);
                    Console.WriteLine("o valor do aumento do produto é" + aumento);
                    
                }
                else if (categoria == 2)
                {
                    aumento = (preco * 0.08);
                    Console.WriteLine("o valor do aumento do produto é" + aumento);
                }
                else if (categoria==3)
                {
                    aumento = (preco * 0.1);
                    Console.WriteLine("o valor do aumento do produto é" + aumento);
                }
                else
                {
                    Console.WriteLine("A categoria digitada não é válida");
                }
               
            }
            
            else if (preco>25)
            {

                if (categoria == 1)
                {
                    aumento = (preco*0.12);
                    Console.WriteLine("o valor do aumento do produto é" + aumento);
                }
                else if (categoria == 2)
                {
                    aumento = (preco * 0.15);
                    Console.WriteLine("o valor do aumento do produto é" + aumento);
                }
                else if (categoria == 3)
                {
                    aumento = (preco * 0.18);
                    Console.WriteLine("o valor do aumento do produto é" + aumento);
                }
                else
                {
                    Console.WriteLine("A categoria digitada não é válida");
                }
                
                
            }

                Console.WriteLine("Digite a situação do produto (R=>Refregeração, N=>Sem refrigeração)");
                situacao = Convert.ToString(Console.ReadLine());

            if ((categoria == 2) && (situacao == "r"))
            {
                imposto = (preco*0.05);
                Console.WriteLine("Ao produto será acrescido um valor de " + imposto + "em impostos");
            }
            else 
            {
                imposto = (preco * 0.08);
                Console.WriteLine("Ao produto será acrescido um valor de " + imposto + "em impostos");
            }

            Console.WriteLine("O novo preço é :"+novpreco);

            if (novpreco<=50)
            {
                Console.WriteLine("O novo preço é classificado como BARATO");
            }
            else if (novpreco < 120)
            {
                Console.WriteLine("O novo preço é classificado como NORMAL " );
            }
            else
            {
                Console.WriteLine("O novo preço é classificado como CARO ");
            }



            Console.WriteLine("fim");
            Console.ReadKey();
        }
    }
}



