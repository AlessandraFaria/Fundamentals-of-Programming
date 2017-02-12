//
// programa prova1.cs
// programadores: Alessandra Faria Abreu e Igor Santana
// data: 02/02/2016 
// descricao: exemplo de passagem de parametros na linha de comando (lc)
// entrada(s) : parametros na linha de comandos (lc), sendo: 
// o numero de matricula (6 dígitos)e o nome completo do aluno 
// saida(s): exibe na tela os parametros na linha de comandom (lc)
// para executar  e testar digite: 
// arglc.exe 573831 Alessandra Faria  
// descricao de parametros opcionais na lc (variaveis pre-definidas do command prompt ou shell)
// args[0]:  primeiro parametro posicional na lc
// args[1] e args[8] segundo e nono parametros posicionais na lc
//
using System;
using System.Text;

namespace Prova1 {
   class Prova1 { //programa prova1_s116.cs
	static void Main(string[] args) {
	 	int i,j, x, A=0, B=0, C=0, NMAT;
	  	int[ ] vetor = new int[10];
	  	string NOME1, NOME2;
      	  	double r = 0;
	  	j = args.Length; //tamanho do args

	  	NMAT = int.Parse(args[0]); //conversão para inteiro
	  	x = NMAT; //inteiro recebe inteiro
	  	NOME1 = args[1];  NOME2 = args[2]; //definição dos valores das variaveis

	  	for (i = 0; x > 0; i++)  { //enquanto foi maior que o tamnho do args
          	  		vetor[i] = x % 10 + j; 
          	 		x = x / 10;
      	  	}

	  	A = vetor[1]; B = vetor[2]; C = vetor[3];//recebem os valores dos vetores definidos no FOR

	  	Console.WriteLine("Desenvolvedores Alessandra Faria Abreu e Igor Santana"); //imprime o nome OBRIGATÓRIO
	  	Console.WriteLine("NOME1 = " + NOME1 + " NOME2 = " +  NOME2); //imprime o nome digitado
	  	
	  	Console.WriteLine("A = " + A + " B = " + B + " C = " + C ); //imprime o vetor com valores antigos
	  	Faz1(A, B, C); // primeira chamada
	  	Console.Write("A = " + A + " B = " + B + " C = " + C ); //imprime o vetor com valores antigos(não foram referenciados)
	  	
	  	Console.WriteLine(" r = " + r);//imprime R=0
	  	r = Faz2(ref A, ref B, ref C); //segunda chamada
	  	Console.Write("A = " + A + " B = " + B + " C = " + C ); 
	  	Console.WriteLine(" r = " + r);	          //r = w
  	}
		
	public static void Faz1(int x, int y,  int z) {
      		Console.WriteLine("x = " + x + " y = " + y + " z = " + z);
	  	x = x + 10; y = y + 20; z = z + 30;
      		z = x + y + z;
      		Console.WriteLine("x = " + x + " y = " + y + " z = " + z);
    	}

	public static  double Faz2(ref int x, ref int y, ref int z){
		double w = 0;
	  	Console.WriteLine("x = " + x + " y = " + y + " z = " + z);
	  	x = x + 10; y = y + 20; z = z + 30;
      		z = x + y + z;
      		Console.WriteLine("x = " + x + " y = " + y + " z = " + z);
      		w = x + y + z;
      		Console.Write("x = " + x + " y = " + y + " z = " + z);
     		 Console.WriteLine(" w = " + w);
      		return (w);
    	}
   }
}


