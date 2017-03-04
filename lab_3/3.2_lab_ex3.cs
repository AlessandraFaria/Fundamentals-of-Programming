using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex32labex3
{

    class Testa_Contas
    {
        const int MAXCONTAS = 100;
        static Conta[] vetContas = new Conta[MAXCONTAS];

        static Conta chamaConta;

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

        static void Main(string[] args)
        {
            int cont = 1;
            string op;
            do
            {
                menu();
                Console.Write("\nEntre com a opcao: ");
                op = Console.ReadLine();
                switch (op)
                {

                    case "1":
                        Console.Clear();
                        Console.WriteLine("1. Criar uma nova conta ");
                        Console.WriteLine("----------------------------------------------");

                        Console.WriteLine("Digite o nome do titular");
                        string nomeTitular = Console.ReadLine();
                        Console.WriteLine("Digite o Tipo de conta : corrente (1), poupança (2), investimento (3)");
                        int TipoConta = Convert.ToInt32(Console.ReadLine());
                        if ((TipoConta == 1) || (TipoConta == 2) || (TipoConta == 3))
                        {
                            chamaConta = new Conta(nomeTitular, 1, TipoConta, cont);
                            vetContas[cont - 1] = new Conta(nomeTitular, 1, TipoConta, cont);
                            vetContas[cont - 1] = chamaConta;
                            cont++;
                            Console.WriteLine("Conta criada com sucesso - Digite qualquer tecla para sair.");
                        }
                        else { Console.WriteLine("Esse tipo de conta não existe - Digite qualquer tecla para sair."); }
                        Console.ReadKey();
                        break;

                    case "2":
                        Console.Clear();
                        Console.WriteLine("2. Excluir uma conta existente");
                        Console.WriteLine("----------------------------------------------");
                        ExcluirConta(cont);
                        Console.ReadKey();
                        break;

                    case "3":
                        fazDeposito(cont);
                        break;

                    case "4":
                        fazSaque(cont);
                        break;

                    case "5":
                        ImprimeSaldo(cont);
                        break;
                    case "6":
                        Console.Clear();
                        Console.WriteLine("6. Imprimir relação das contas existentes informando os dados das contas ");
                        Console.WriteLine("----------------------------------------------");
                        RelacaoNContas(cont);
                        Console.ReadKey();
                        break;
                    case "7":
                        Console.Clear();
                        Console.WriteLine("\n 7. Finalizar o programa \n");
                        Console.WriteLine("----------------------------------------------");
                        break;

                    default:
                        Console.Clear();
                        Console.WriteLine("Opção Inválida.");
                        break;
                }
            } while (op != "7");

            Console.WriteLine("\n Programa terminado");
            Console.WriteLine("\n Aperte qq tecla para sair");
            Console.ReadKey();
        }

        static void fazDeposito(int quantasContas)
        {
            int numero_conta;
            double credito;
            Console.Clear();
            Console.WriteLine("Deposito em conta");
            Console.WriteLine("----------------------------------------------");
            Console.Write("Entre com o numero da conta: ");
            numero_conta = int.Parse(Console.ReadLine());
            if (numero_conta > 0 && numero_conta <= quantasContas)
            {
                if (vetContas[numero_conta - 1].Inativa == false)
                {
                    Console.Write("Digite o valor a ser depositado na conta:");
                    credito = double.Parse(Console.ReadLine());
                    if (credito > 0)
                    {
                        chamaConta.Deposita(credito, numero_conta, vetContas);
                        Console.WriteLine("Depósito realizado.");
                    }
                    else
                    {
                        Console.WriteLine("Valor negativo, operacao nao efetuada! ");
                    }
                }
                else
                {
                    Console.WriteLine("Conta Inativa");
                }
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
            int numero_conta;
            double quantia;
            double test_result;
            Console.Clear();
            Console.WriteLine("Saque em conta");
            Console.WriteLine("----------------------------------------------");
            Console.Write("Entre com o numero da conta: ");
            numero_conta = int.Parse(Console.ReadLine());
            if (numero_conta > 0 && numero_conta <= quantasContas)
            {
                if (vetContas[numero_conta - 1].Inativa == false)
                {
                    Console.Write("Digite o valor a ser depositado na conta:");
                    quantia = double.Parse(Console.ReadLine());

                    test_result = chamaConta.Sacar(quantia, numero_conta, vetContas);
                    if (test_result == quantia)
                        Console.WriteLine("Saque realizado no valor " + quantia);
                    else
                        Console.WriteLine(" SALDO INSUFICIENTE: RETIRADA NÃO EFETUADA! ");
                }
                else
                {
                    Console.WriteLine("Conta Inativa");
                }
            }
            else
            {
                Console.WriteLine("Conta invalida, operacao nao efetuada! ");
            }
            Console.WriteLine("Digite qualquer tecla para voltar para o menu.");
            Console.ReadKey();
        }

        static void ImprimeSaldo(int quantasContas)
        {
            int numero_conta;
            Console.Clear();
            Console.WriteLine("Imprimir saldo de uma conta");
            Console.WriteLine("----------------------------------------------");
            Console.Write("Entre com o numero da conta: ");
            numero_conta = int.Parse(Console.ReadLine());
            if (numero_conta > 0 && numero_conta <= quantasContas)
            {
                Console.WriteLine(" SALDO : " + chamaConta.SaldoImprime(numero_conta, vetContas));
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
            int numero_conta;
            // Conta chamaConta;
            Console.Clear();
            Console.WriteLine("Imprimir relação da conta");
            Console.WriteLine("----------------------------------------------");

            for (numero_conta = 1; numero_conta < quantasContas; numero_conta++)
            {
                if (vetContas[numero_conta - 1].Inativa == false)
                {
                    Console.WriteLine(" Informações : Número da conta {0} , Titular {1}", vetContas[numero_conta - 1].NumConta, vetContas[numero_conta - 1].Titular);
                    Console.WriteLine("Informações impressas.");
                }
                else
                {
                    Console.WriteLine("Conta Inativa");
                }
            }
            Console.WriteLine("Digite qualquer tecla para voltar para o menu.");
            Console.ReadKey();
        }
       
        static void ExcluirConta(int quantasContas)
        {
            int numero_conta;
            Console.Clear();
            Console.WriteLine("Excluir Conta");
            Console.WriteLine("----------------------------------------------");
            Console.Write("Entre com o numero da conta: ");
            numero_conta = int.Parse(Console.ReadLine());
            if (numero_conta > 0 && numero_conta <= quantasContas)
            {
                Console.WriteLine(" Excluindo: " + chamaConta.Excluir(numero_conta, vetContas));
                Console.WriteLine("Conta excluida.");
            }
            else
            {
                Console.WriteLine("Conta invalida, operacao nao efetuada! ");
            }
            Console.WriteLine("Digite qualquer tecla para voltar para o menu.");
            Console.ReadKey();
        }

    }


    class Conta
    {
        private String titular;
        private int agencia;
        private int numConta;
        private int tipoConta;
        private double saldo;
        bool inativa;


        public Conta(String nome, int ag, int tipo, int nuncont)
        {//construtor
            titular = nome;
            agencia = ag;
            tipoConta = tipo;
            numConta = nuncont;
            inativa = false;
        }

        public void Deposita(double credito, int numContas, Conta[] vetContas)
        {
            saldo += credito;
            vetContas[numContas - 1].saldo = saldo;
        }

        public double Sacar(double quantia, int numContas, Conta[] vetContas)
        {
            if (saldo >= quantia)
            {
                saldo -= quantia;
                vetContas[numContas - 1].saldo = saldo;
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

        public double SaldoImprime(int numContas, Conta[] vetContas)
        {
            return vetContas[numContas - 1].saldo;
        }

        public bool Excluir(int numContas, Conta[] vetContas)
        {
            vetContas[numContas - 1].inativa = true;
            return vetContas[numContas - 1].inativa;
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

        public bool Inativa
        {
            get { return inativa; }

        }

        public string Titular
        {
            get { return titular; }
        }

    }

}
