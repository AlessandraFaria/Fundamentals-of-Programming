using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication7
{
    class Program
    {//ALESSANDRA FARIA ABREU
        static void Main(string[] args)
        {
            double h;
            double horaex;
            double horafa;
            double premio;

            Console.WriteLine("digite o numero de horas extras trabalhadas");
            horaex = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("digite o numero de horas faltadas");
            horafa = Convert.ToDouble(Console.ReadLine());

            h = horaex - (1.5*horafa);
            
            // PODIA TER SIDO FEITO DESSA FORMA 
            
            //if (h < 40)
            // {
            //   premio = h * 10;
            //   Console.WriteLine("o valor do prênio é "+premio);
            // }
            //else{
              //  premio = 500;
                //Console.WriteLine("o valor do prênio é " + premio);
            //}


            if (h < 10)
            {
                premio = 100;
                Console.WriteLine("o funcionario ganhara um prêmio de " + premio);
            }
            else if (h < 20)
            {
                premio = 200;
                Console.WriteLine("o funcionario ganhara um prêmio de " + premio);
            }
            else if ((h <= 30)&&(h>=20))
            {
                premio = 300;
                Console.WriteLine("o funcionario ganhara um prêmio de " + premio);

            }
            else if ((h<=30)&&(h<40))
            {
                premio = 400;
                Console.WriteLine("o funcionario ganhara um prêmio de " + premio);
            }
            else
            {
                premio = 500;
                Console.WriteLine("o funcionario ganhara um prêmio de " + premio);
            }



            Console.WriteLine("fim");
            Console.ReadKey();
        }
    
}
    
}
