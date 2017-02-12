//
// nome do programa: 3.4_lab_ex1.cs
//
// programadores: Alessandra Faria Abreu e Igor Santana
// data: data:05/02/2017
// entrada(s): 1- numero de eleitores composto por numero inteiro através da linha de comando 
// 2-numeros inteiros que correspndem aos códigos de votação
// saida(s): nome dos candidatos cadastrados , a quantidade de votos e a porcentagem dos mesmos,
// para executar  e testar digite: 
// 3.4_lab_ex1.exe 4(número de eleitores)
//votos válidos 33 ,21 ou 19
// descricao: recebe um numero de eleitores string através da linha de comando,
// converte para inteiro ,solicita os votos pela linha de comando 
//converte para inteiro e armazena em um vetor , chama um método estático que receba estes
// votos inteiros faz os separa de acordo com o código do candidato,  retorna o numero de votos de cada candidato
//e a sua porcentagem 
//

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex34labex1
{
    class Program
    {
        static void Main(string[] args)
        {
            int eleitores=0 ;
            int voto_invalido = 0;

            eleitores = int.Parse(args[0]);
            int[] vetor = new int[eleitores];

            Console.WriteLine("Desenvolvedores Alessandra Faria Abreu e Igor Santana"); //imprime o nome OBRIGATÓRIO
            for (int i=0;i<eleitores;i++)
            {
                Console.WriteLine("Digite os votos do eleitor "+ i);
                vetor[i] = Convert.ToInt32(Console.ReadLine());
            }
            Contavotos(vetor,eleitores,voto_invalido);

        }

        static void  Contavotos(int[] vetor,int eleitores,int voto_invalido)
        {
            int candidato1=0, candidato2=0, candidato3=0;
            double result_cand1=0;
            double result_cand2=0;
            double result_cand3=0;

            for (int j=0;j<eleitores; j++) {

                switch (vetor[j])
                {
                    case 19:
                        candidato1++;
                        break;
                    case 21:
                        candidato2++;
                        break;
                    case 33:
                        candidato3++;
                        break;
                    default:
                        Console.WriteLine("O voto do eleitor "+j+" está errado");
                        voto_invalido++;
                        break;
                }
            }
            result_cand1=(candidato1 * 100) / (eleitores - voto_invalido);
            result_cand2=(candidato2 * 100) / (eleitores - voto_invalido);
            result_cand3=(candidato3 * 100) / (eleitores - voto_invalido);

            Console.WriteLine("votos Machado de Assis : "+candidato1+" a porcentegem correspondente é  "+ result_cand1 + "%");
            Console.WriteLine("votos Guimarães Rosa : " + candidato2 + " a porcentegem correspondente é  " + result_cand2 + "%");
            Console.WriteLine("votos Cecilia Meireles : : " + candidato3 + " a porcentegem correspondente é  " + result_cand3+"%");
            Console.WriteLine("votos invalidos : : " + voto_invalido) ;

            if((result_cand1>52)||(result_cand2>52)||(result_cand3>52)){
                if((result_cand3==result_cand1)||result_cand3==result_cand2){
                    Console.WriteLine("SEGUNDO TURNO");
                }
                if((result_cand1==result_cand2)||result_cand1==result_cand3){
                    Console.WriteLine("SEGUNDO TURNO");
                }
                if((result_cand2==result_cand1)||result_cand2==result_cand3){
                    Console.WriteLine("SEGUNDO TURNO");
                }

            }

        }




    }
}
