
//Programa de teste do sistema de arquivos
//Alunos Sicrano de tal e Fulano José
//Arquivo texto de entrada: entrada.txt
//Arquivo texto de saída: saida.txt
//Entre com os caracteres: a x r s q w z*
//Caracteres digitados: a x r s q w z
//Caracteres convertidos: A X R S Q W Z

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
namespace copia_texto_2
{

    class copia_texto_linha_s116
    {

        static void Main(string[] args)
        {
            string nomeEntrada, nomesaida;
            nomeEntrada = args[0];
            nomesaida = args[1];
            char[] vetor1 = new char[20];
            string[] vetor2 = new string[20];
            int  i=0;

            Stream fileEntrada = File.Open(args[0], FileMode.Open); // abrir arquivo
            Stream fiSaida = File.Open(args[1], FileMode.Create); // criar arquivo

            Console.WriteLine("Programa de teste do sistema de arquivos");
            Console.WriteLine("Alessandra Faria , Alaene ,victor souza , Igor santana ...");
            Console.WriteLine("Arquivo de Texto de entrada: " +args[0]);
            Console.WriteLine("Arquivo de Texto de saída: " + args[1]);

            BinaryWriter entrada = new BinaryWriter(fileEntrada);
            BinaryWriter saida = new BinaryWriter(fiSaida);

            Console.WriteLine("Entre com os caracteres:");
            string verificaTexto = Console.ReadLine();
            char textoEscrito = Convert.ToChar(verificaTexto);
            while (verificaTexto != "*")
            {
                textoEscrito = Convert.ToChar(verificaTexto);

                vetor1[i] = textoEscrito;
                if (vetor1[i] < 0) break; // erro no arquivo
                if (vetor1[i] == 0) break; // fim de arquivo
                entrada.Write(vetor1[i]);

                i++;

                Console.Write("");
                verificaTexto = Console.ReadLine();
            }
            entrada.Close();
            Console.Write("Caracteres digitados ");
            for (int j = 0; j < 20; j++)
            {
                string vetor1String = Convert.ToString(vetor1[j]);
                string linhaConvertida = vetor1String.ToUpper();
                vetor2[j] = linhaConvertida;
                if (vetor1[j] < 0) break; // erro no arquivo
                if (vetor1[j] == 0) break; // fim de arquivo
                saida.Write(vetor2[j]);
                Console.Write(vetor1[j]+ " ");

            }
            Console.WriteLine(" ");
            saida.Close();

            Console.Write(" Caracteres convertidos ");
            for (int k=0;vetor2[k]!=null;k++)
            {
                Console.Write(vetor2[k]);
            }

        }
    }
}
