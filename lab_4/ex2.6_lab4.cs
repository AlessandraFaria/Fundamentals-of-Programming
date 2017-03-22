using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
namespace copia_texto_2{

    class copia_texto_linha_s116
{

    static void Main(string[] args) {
           
            string[] vetor1 = new string[20];
            string[] vetor2 = new string[20];
            string linha;
            string nomeEntrada=args[0];

            FileInfo fi = new FileInfo(args[0]);
            FileInfo fisai = new FileInfo(args[1]);
            Console.WriteLine("Alessandra Faria , Alaene ,victor souza , Igor santana ...");
            Console.WriteLine("Arquivo de Texto de entrada: " + fi.Name);
            Console.WriteLine("Arquivo de Texto de saída: " + fisai.Name);

            StreamWriter entrada = new StreamWriter(args[0]); //abrir o arquivo origem;
            StreamWriter saida = new StreamWriter(args[1]); //abre arquivo de destino 

            Console.WriteLine("Entre com os caracteres:");
            string textoEscrito = Console.ReadLine();
            while (textoEscrito != "*")
            {
                for (int i = 0; i < 1; i++)
                {
                    vetor1[i] = textoEscrito;
                    entrada.WriteLine(vetor1[i]);

                }
                Console.Write("");
                textoEscrito = Console.ReadLine();
            }
            entrada.Close();
            StreamReader entrada2 = new StreamReader(nomeEntrada); //abrir o arquivo origem
            for (int j = 0; j < fi.Length; j++){
                linha = entrada2.ReadLine();     //ler 1a linha
                while (linha != null)           //enquanto houver dados...
                {
                    linha=text.ToUpper();
                    vetor2[j] = linha; //Formatar
                    saida.WriteLine(vetor2[j]);    //escreve no arquivo
                    linha = entrada2.ReadLine(); //ler proxima linha
                    j++;
                    Console.WriteLine(vetor2[j]);
                }
            }
            entrada2.Close();
            saida.Close();


        }
}
}
