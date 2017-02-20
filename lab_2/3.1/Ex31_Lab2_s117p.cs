//
// nome do programa: 3.1_lab_ex2.cs
//
// Desenvolvedores Alessandra Faria Abreu (573831) e Matheus Cunha Nicoloni (555083)
// data: data:16/02/2017
// entrada(s): numero de conta composto por  numeros inteiros através da linha de comando 
// nome do titular da conta , string (texto)
//2-entrada : opção escolhida do menu
// saida(s): menu principal com opções 
//1 - Fazer Deposito 
//(entrada: valor para deposito)
//2 - Realizar Saque 
//(entrada: valor para saque)
// 3 - Verificar Saldo 
// 4 - Encerrar seção
// para executar  e testar digite: 
// 3.1_lab_ex2.exe (qualque numero para conta) (qualquer nome)
// descricao: recebe o numero da conta e o nome do titular como string através da linha de comando,
// converte para inteiro o numero da conta e armazena em uma variável , imprime o menu principal com as opções de ação
// pede para o usuário digitar a opção e a armazena em uma variável
//apos amarzenada a opção é avaliada e se estiver correta chama-se o metodo correspondente
//os metodos chamados pertencem a classe Conta que é instanciada pelo objeto chamaconta
//junto ao objeto vão para o metodo o valor escolhido pelo usuário nas opções 1 e 2 .
//
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex31labex2
{
    class Menu
    {
        static Conta chamaConta;

        static void Main(string[] args)
        {
            int opcao = 0;
            int numero = int.Parse(args[0]);
            string nome = args[1];

            Console.WriteLine("Desenvolvedores Alessandra Faria Abreu e Matheus Cunha"); //imprime o nome OBRIGATÓRIO
            Console.WriteLine("\n\t\t\tMENU Banco " + nome+"\t\t\t\t " +
                    "\n 1 - Fazer Deposito \t" +
                    "\n 2 - Realizar Saque \t" +
                    "\n 3 - Verificar Saldo \t" +
                    "\n \t\t\t\t\t\t\t " +
                    "\n 4 - Encerrar seção\t\t\t\t\t" +
                    "\n \t\t\t\t\t\t\t ");
            opcao = Convert.ToInt32(Console.ReadLine());
           

            chamaConta = new Conta(nome);
            while (opcao!=4) {
                switch (opcao)
                {
                    case 1:
                        Console.Clear();
                        Console.WriteLine("digite o valor que deseja depositar");
                        double valor_dep = Convert.ToDouble(Console.ReadLine());
                        TestaDeposito(valor_dep);                     
                        break;
                    case 2:
                        Console.Clear();
                        Console.WriteLine("digite o valor que deseja sacar");
                        double valor_sac = Convert.ToDouble(Console.ReadLine());
                        TestaSac(valor_sac);
                        break;
                    case 3:
                        Console.Clear();
                        Console.WriteLine("O saldo da conta é " + chamaConta.ObterSaldo());
                        break;                    
                    default:
                        Console.Clear();
                        Console.WriteLine("Opção Inválida.");
                        break;
                }
                
                Console.WriteLine("\n\t\t\tMENU Banco\t\t\t\t " +
                    "\n 1 - Fazer Deposito de valor\t" +
                    "\n 2 - Realizar Saque de valor\t" +
                    "\n 3 - Verificar Saldo da conta\t" +
                    "\n \t\t\t\t\t\t\t " +
                    "\n 4 - Encerrar seção\t\t\t\t\t" +
                    "\n \t\t\t\t\t\t\t ");
                opcao = Convert.ToInt32(Console.ReadLine());
            }
            
        }
        static void TestaDeposito(double valor_dep)
        {
            if (valor_dep > 0)
            {
                Console.WriteLine("Depositando valor");
                chamaConta.Deposita(valor_dep);
            }
            else
            {
                Console.WriteLine("valor negativo não pode ser depositado");
            }
        }
        static void TestaSac(double valor_sac)
        {
            if (valor_sac > 0)
            {
                Console.WriteLine("Sacando");
                chamaConta.Retira(valor_sac);
            }
            else
            {
                Console.WriteLine("valor negativo não pode ser sacado");
            }
        }

        }
    class Conta {
        private double saldo = 0;
        private string nome;

        public Conta(String nome)
        {
            this.saldo = 0;
            this.nome = nome;
        }
        
        public void Deposita(double valor)
        {
            saldo += valor;
        }
        public void Retira(double valor)
        {
            if ((saldo != 0)&&(saldo>valor))
            {
                saldo -= valor;
            }
            else
            {
                Console.WriteLine("Saldo inssuficiente");
            }
            
        }
        public double ObterSaldo()
        {
            return saldo;
        }
    }

}