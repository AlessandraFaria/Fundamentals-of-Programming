
//
// nome do programa: 3.3_lab_ex1.cs
//
// programadores: Alessandra Faria Abreu e Igor Santana
// data: data:03/02/2017
// entrada(s): data compostapor  numeros inteiros através da linha de comando 
// o numero do dia , do mes e do ano 
// saida(s): imprime um numero do tipo double com a quantidade de dias pecorridos,
// para executar  e testar digite: 
// 3.3_lab_ex1.exe 15 3 2020
// descricao: recebe uma data em numeros string através da linha de comando,
// converte para inteiro e armazena em um vetor , imprime a data e chama um método estático que receba estes
// números inteiros faz os calculos necessrios para saber os dias pecorridos,  e retorna a quandidade
//de dias pecorridos desde 01/01/(ano digitado)
//

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex33labex1
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, tamanho_args, dia = 0, mes = 0, ano = 0;
            int[] vetor = new int[3];
            tamanho_args = args.Length;
            for (i = 0; i < tamanho_args; i++)
            {
                vetor[i] = int.Parse(args[i]);
            }

            dia = vetor[0];
            mes = vetor[1];
            ano = vetor[2];

            Console.WriteLine("Desenvolvedores Alessandra Faria Abreu e Igor Santana"); //imprime o nome OBRIGATÓRIO
            Console.WriteLine("Dia = " + dia + " Mês = " + mes + " Ano = " + ano); //imprime o vetor com valores antigos
            Console.WriteLine("a quantidade de dias pecorridos desde 01/01/" + ano + "é : " + quantosDias(dia, mes, ano) + " dias");

        }

        static double quantosDias(int dia, int mes, int ano)
        {
            double somadia = 0;
            double somames = 0;
            double somaano = 0;
            double contadias = 0;
            double[] vetor_dia_mes_bi = { 30, 29, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
            double[] vetor_dia_mes = { 31, 28, 31, 29, 31, 30, 29, 31, 30, 31, 30, 30 };
            int resto = ano % 4;
            
                if (dia != 1)
                {
                    somadia = dia;

                }
                if (resto != 0)
                {

                    if (mes != 1)
                    {
                        for (int i = 0; i < (mes-1); i++)
                        {
                            somames = somames + vetor_dia_mes[i];
                        }
                        somames = somames + somadia;
                        somadia = 0;
                    }
                    
                }
                else
                {
                    if (mes != 1)
                    {
                        for (int i = 1; i < mes; i++)
                        {
                            somames = somames + vetor_dia_mes_bi[i];
                        }
                        somames = somames + somadia;
                        somadia = 0;
                    }
                    
                }

                contadias = somadia + somames;
            
            return contadias;
        }
    }
}
