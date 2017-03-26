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
            char[] vetor2 = new char[20];
            int  i=0;

            Stream fileEntrada = File.Open(args[0], FileMode.Open); // abrir arquivo
            Stream fiSaida = File.Open(args[1], FileMode.Create); // criar arquivo

            Console.WriteLine("Alessandra Faria , Alaene ,victor souza , Igor santana ...");
            //Console.WriteLine("Arquivo de Texto de entrada: " + fileEntrada.Name);
            //Console.WriteLine("Arquivo de Texto de saída: " + fiSaida.Name);

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

            for (int j = 0; j < 20; j++)
            {
                vetor2[j] = vetor1[j];
                if (vetor1[j] < 0) break; // erro no arquivo
                if (vetor1[j] == 0) break; // fim de arquivo
                saida.Write(vetor2[j]);

            }
           
            saida.Close();



        }
    }
}
