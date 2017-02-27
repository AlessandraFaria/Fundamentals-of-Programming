
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex32labex3
{
    class Testa_Contas
    {
        public static void menu()
        {
            Console.Clear();
            Console.WriteLine("Gerencia de contas");
            Console.WriteLine("----------------------------------------------");
            Console.WriteLine("1. Criar uma nova conta ");
            Console.WriteLine("2. Excluir uma conta existente");
            Console.WriteLine("3. Depositar em uma conta");
            Console.WriteLine("4. Sacar de uma conta");
            Console.WriteLine("5. Imprimir saldo de uma conta");
            Console.WriteLine("6. Imprimir relação das contas existentes informando os dados das contas ");
            Console.WriteLine("7. Finalizar o programa");

        }
        const int MAXCONTAS = 100;
        static Conta[] vetContas = new Conta[MAXCONTAS];
        static void Main(string[] args)
        {
                int cont = 0;                 // contador de contas existentes
                int op;                     // obter a opcao  do usuario
                do
                {
                    menu();
                    Console.Write("\nEntre com a opcao: ");
                    op = int.Parse(Console.ReadLine());
                    switch (op)
                    {

                        case 1:
                            Console.Clear();
                            Console.WriteLine("1. Criar uma nova conta ");
                            Console.WriteLine("----------------------------------------------");
                            cont++;
                            Console.WriteLine("Digite o nome do titular");
                            string nomeTitular = Console.ReadLine();
                            Console.WriteLine("Digite o Tipo de conta : corrente (1), poupança (2), investimento (3)");
                            int TipoConta = Convert.ToInt32(Console.ReadLine());
                            if ((TipoConta==1)||(TipoConta==2)||(TipoConta==3))
                            {
                                vetContas[cont - 1] = new Conta(nomeTitular, 1, TipoConta,cont);
                                vetContas[cont - 1].Deposita(0);
                                Console.WriteLine("Conta criada com sucesso - Digite qualquer tecla para sair.");
                            }
                            else { Console.WriteLine("Esse tipo de conta não existe - Digite qualquer tecla para sair."); }
                            Console.ReadKey();
                            break;

                        case 2:
                            Console.Clear();
                            Console.WriteLine("2. Excluir uma conta existente");
                            Console.WriteLine("----------------------------------------------");
                            ExcluirConta(cont);
                            Console.ReadKey();
                            break;

                        case 3:
                            fazDeposito(cont);
                            break;

                        case 4:
                             fazSaque(cont);  
                            break;

                        case 5:
                            ImprimeSaldo(cont); 
                            break;
                        case 6:
                            Console.Clear();
                            Console.WriteLine("6. Imprimir relação das contas existentes informando os dados das contas ");
                            Console.WriteLine("----------------------------------------------");
                            RelacaoNContas(cont);
                            Console.ReadKey();
                            break;
                        case 7:
                            Console.Clear();
                            Console.WriteLine("\n 7. Finalizar o programa \n");
                            Console.WriteLine("----------------------------------------------");  
                            break;

                        default: break;
                    } 
                } while (op != 7);   

                Console.WriteLine("\n Programa terminado");
                Console.WriteLine("\n Aperte qq tecla para sair");
                Console.ReadKey();
            }

        static void fazDeposito(int quantasContas)
        {
            int cc;
            double credito;
            Conta aux;
            Console.Clear();
            Console.WriteLine("Deposito em conta");
            Console.WriteLine("----------------------------------------------");
            Console.Write("Entre com o numero da conta: ");
            cc = int.Parse(Console.ReadLine());
            if (cc > 0 && cc <= quantasContas)
            {
                Console.Write("Digite o valor a ser depositado:");
                credito = double.Parse(Console.ReadLine());  
                aux = vetContas[cc - 1];                    
                aux.Deposita(credito);                       
                Console.WriteLine("Depósito realizado.");
            }
            else
            {
                Console.WriteLine("Conta invalida, operacao nao efetuada! ");
            }
            Console.WriteLine("Digite qualquer tecla para voltar para o menu.");
            Console.ReadKey();

        }

        static void fazSaque(int quantasContas)
        {
            int cc;
            double valor, resultado;
            Conta aux;
            Console.Clear();
            Console.WriteLine("Saque em conta");
            Console.WriteLine("----------------------------------------------");
            Console.Write("Entre com o numero da conta: ");
            cc = int.Parse(Console.ReadLine());
            if (cc > 0 && cc <= quantasContas)
            {
                Console.Write("Digite o valor a ser Sacado:");
                valor = double.Parse(Console.ReadLine());   // ler valor do saque
                aux = vetContas[cc - 1];                     // copia dados do vetor
                resultado = aux.Sacar(valor);  // chama metodo para sacar da conta
                if (resultado == valor)
                    Console.WriteLine("Saque realizado no valor " + valor);
                else
                    Console.WriteLine(" SALDO INSUFICIENTE: RETIRADA NÃO EFETUADA! ");
            }
            else
            {
                Console.WriteLine("Conta invalida, operacao nao efetuada! ");
            }
            Console.WriteLine(" Digite qualquer tecla para voltar para o menu.");
            Console.ReadKey();
        }

        static void ImprimeSaldo(int quantasContas)
        {
            int cc;
            Conta aux;
            Console.Clear();
            Console.WriteLine("Imprimir saldo de uma conta");
            Console.WriteLine("----------------------------------------------");
            Console.Write("Entre com o numero da conta: ");
            cc = int.Parse(Console.ReadLine());
            if (cc > 0 && cc <= quantasContas)
            {
                aux = vetContas[cc - 1];    //copia dados do vetor
                Console.WriteLine(" SALDO : " + aux.Saldo);
                Console.WriteLine("Saldo impresso.");
            }
            else
            {
                Console.WriteLine("Conta invalida, operacao nao efetuada! ");
            }
            Console.WriteLine("Digite qualquer tecla para voltar para o menu.");
            Console.ReadKey();

        }

          static void RelacaoNContas(int quantasContas)
        {
            int cc;
            Conta aux;
            Console.Clear();
            Console.WriteLine("Imprimir relação da conta");
            Console.WriteLine("----------------------------------------------"); 
            for (cc=1;cc<=quantasContas;cc++)
            {
                aux = vetContas[cc - 1];    //copia dados do vetor
                Console.WriteLine(" Informações : Número da conta {0} , Titular {1}", aux.NumConta, aux.Titular);
                Console.WriteLine("Informações impressas.");
            }
            Console.WriteLine("Digite qualquer tecla para voltar para o menu.");
            Console.ReadKey();
        }
        //static void ExcluirConta(int quantasContas)
        //{
        //    int cc;
        //    Conta aux;
        //    Console.Clear();
        //    Console.WriteLine("Excluir Conta");
        //    Console.WriteLine("----------------------------------------------");
        //    for (cc = 1; cc <= quantasContas; cc++)
        //    {
        //        aux = vetContas[cc - 1];    //copia dados do vetor
        //        aux.numConta=0;
        //        aux.titular=0;
        //        Console.WriteLine("Informações impressas.");
        //    }
        //    Console.WriteLine("Digite qualquer tecla para voltar para o menu.");
        //    Console.ReadKey();
        //}

    }


    class Conta {
        private String titular;
        private int agencia; 
        private int numConta; 
        private int tipoConta; 
        private double saldo;

        public Conta(String nome, int ag, int tipo ,int nuncont){
        titular = nome;
	    agencia = ag;
        tipoConta = tipo;
        numConta = nuncont;
    }
        public void Deposita(double valor)
        {
            saldo += valor;
        }
        public double Sacar(double quantia)
        {
            if (saldo >= quantia)
            {
                saldo -= quantia;
                return quantia;
            }
            else
            {
                return 0;
            }
        }
        public double Saldo
        {
            get { return saldo; }
            set
            {
                if (value > 0.0) saldo = value;
                else saldo = 0.0;
            }
        }
        public int NumConta
        {
            get { return numConta; }
            set
            {
                if (value > 0) numConta = value;
                else numConta = 0;
            }
        }
        public string Titular
        {
            get { return titular; }
            //set
            //{
            //    if (value > 0) numConta = value;
            //    else numConta = 0;
            //}
        }
    }

    }
