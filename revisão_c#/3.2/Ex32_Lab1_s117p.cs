//
// nome do programa: Ex32_Lab1_s117p.cs
//
// programadores: Paulo Amaral Programadores AUX  Alessandra Faria Abreu e Igor Santana
// data: 28/01/2017--data:03/02/2017
// entrada(s): n numeros inteiros através da linha de comando 
// o numero de matricula (6 dígitos)e o nome completo do aluno 
// saida(s): imprime o vetor de números ordenado, o menor,
// para executar  e testar digite: 
// Ex32_Lab1_s117p.exe 573831
// descricao: recebe n numeros inteiros através da linha de comando,
// armazena em um vetor e chama um método estático que receba estes
// números inteiros (armazenados no vetor),  e retorna   o maior
// deles e a média de seus valores.
// ordenar o vetor na ordem crescente de valores,
// obter o menor valor 
//


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex32_lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            int maior = 0, media = 0;
            double menor=0;
            int i, j = 0;
            j = args.Length;
            int[] vetor = new int[j];
            Console.WriteLine("Desenvolvedores Alessandra Faria Abreu e Igor Santana");
            Console.WriteLine("\nPrograma Ex32_Lab1_s117p.exe com " + j + " parametros : ");
            for (i = 0; i < j; i++)
            {
                Console.Write(" args[" + i + "] = " + args[i]);
                Console.Write(" args[{0}] = {1}", i, args[i]);
                vetor[i] = int.Parse(args[i]);
                Console.WriteLine(" vetor[{0}] = {1}", i, vetor[i]);
            }
            Obter_valores(vetor, ref maior, ref media, ref menor);
            Console.WriteLine("Maior : " + maior);
            Console.WriteLine("Media : " + media);
            Console.WriteLine("Menor : "+menor);
            Console.Write("Vetor : ");
            for (int t = 0; t < vetor.Length; t++)
            {
                Console.WriteLine(vetor[t] + ",");
            }

        }

        static void Obter_valores(int[] vet, ref int maior, ref int media, ref double valor_menor)
        {
            // metodo imcompleto - deve ser completado pelo aluno
            int soma = 0;
            int menor = 0;
            int k = 0;
            int aux = 0;
            media = 0; maior = vet[0];
            for (int i = 0; i < vet.Length; i++)
            {
                soma += vet[i];
                if (vet[i] > maior)
                {
                    maior = vet[i];
                }
            }
            media = soma / vet.Length;

            //completando..
            valor_menor = double.MaxValue;
            for (int f=0;f< vet.Length;f++)
            {
                if (vet[f] < valor_menor)
                {
                    valor_menor = vet[f];
                }
            }

            for (k = 0; k < vet.Length; k++)
            {
                menor = k;

                for (int j = k + 1; j < vet.Length; j++)
                {
                    //comparação
                    if (vet[j] < vet[k])
                    {
                        //caso seja menor acontece...
                        menor = j;
                    }
                }
                //faz a troca
                if (menor != k)
                {
                    aux = vet[k];
                    vet[k] = vet[menor];
                    vet[menor] = aux;

                }
            }
        }
    }
}
