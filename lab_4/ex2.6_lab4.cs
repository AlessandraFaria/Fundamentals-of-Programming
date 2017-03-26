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
            byte[] vetor1 = new byte[20];
            byte[] vetor2 = new byte[20];

            Stream fileEntrada = File.Open(args[0], FileMode.Open); // abrir arquivo
            Stream fiSaida = File.Open(args[1], FileMode.Create); // criar arquivo

            Console.WriteLine("Alessandra Faria , Alaene ,victor souza , Igor santana ...");
            //Console.WriteLine("Arquivo de Texto de entrada: " + fileEntrada.Name);
            //Console.WriteLine("Arquivo de Texto de saída: " + fiSaida.Name);

            BinaryWriter entrada = new BinaryWriter(fileEntrada);
            BinaryWriter saida = new BinaryWriter(fiSaida);

            Console.WriteLine("Entre com os caracteres:");
            string verificaTexto = Console.ReadLine();
            byte textoEscrito = Convert.ToByte(verificaTexto);
            while (verificaTexto != "*")
            {
                textoEscrito = Convert.ToByte(verificaTexto);
                for (int i = 0; i < 1; i++)
                {
                    vetor1[i] = textoEscrito;
                    if (vetor1[i] < 0) break; // erro no arquivo
                    if (vetor1[i] == 0) break; // fim de arquivo
                    entrada.Write(vetor1[i]);

                }
                Console.Write("");
                verificaTexto = Console.ReadLine();
            }
            entrada.Close();

            Stream fileEntrada2 = File.Open(args[0], FileMode.Open);
            BinaryReader entrada2 = new BinaryReader(fileEntrada2);
            for (int j = 0; j < fileEntrada2.Length; j++)
            {
                int linha = fileEntrada2.Read(vetor1,0,1);     //ler 1a linha
                while (linha != 0)           //enquanto houver dados...
                {
                    Console.WriteLine(linha + "");
                    byte linhaConvertidaToByte = Convert.ToByte(linha);
                    vetor2[j] = linhaConvertidaToByte;
                    saida.Write(vetor2[j]);
                    //Console.WriteLine(vetor2[j]);
                    linha = fileEntrada2.Read(vetor1,0,1);
                }
            }
            entrada2.Close();
            saida.Close();


        }
    }
}