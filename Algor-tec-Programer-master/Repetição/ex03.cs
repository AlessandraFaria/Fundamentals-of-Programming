using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication14
{
    class Program
    {
        static void Main(string[] args)
        {
            double idade, peso,conta=0;
            string olhos, cabelo;
            double pessoas, aa,b,c,d,idadetotal;
            int altura;
            pessoas = Convert.ToDouble(Console.ReadLine());
            aa = Convert.ToDouble(Console.ReadLine());
            b = Convert.ToDouble(Console.ReadLine());
            c = Convert.ToDouble(Console.ReadLine());
            d = Convert.ToDouble(Console.ReadLine());
            idadetotal = Convert.ToDouble(Console.ReadLine());
            for (conta=1;conta<20;conta++)
            {
                Console.WriteLine("digite a idade da pessoa ");
                idade = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("digite o peso da pessoa ");
                peso = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("digite a altura da pessoa ");
                altura = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("digite a cor dos olhos da pessoa (a,v ou c) ");
                olhos= Convert.ToString(Console.ReadLine());
                Console.WriteLine("digite a cor dos cabelos da pessoa ");
                cabelo = Convert.ToString(Console.ReadLine());
                pessoas++;
                if ((idade>50)&&(peso<60))
                {
                    aa++;
                }
                if (altura<1.50){
                    b=idade;
                    //idadetotal = idade + b;
                }
                if (olhos=="a")
                {
                    c++;
                }
                if ((cabelo=="r")&&!(olhos=="a"))
                {

                }
            }
            Console.WriteLine("a quentidade de pessoas com idade superior o 50 e peso inferior a 60 ´é"+aa);
            Console.WriteLine("a media das idades das pessoas com menos de 1.50 de altura é"+(b)/pessoas);
            Console.WriteLine("");
            Console.WriteLine("");
        }
    }
}
