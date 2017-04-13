using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
namespace lab_5._1_ex12
{
    class Menu
    {
        const int MAXCONTRIBUINTES = 100; // número máximo de contas suportado
        static Contribuinte[] lst = new Contribuinte[MAXCONTRIBUINTES]; //vetor de contribuintes
                                                                        
        static void Main(string[] args)
        {
            int j = 0,k=0 ;
            string opcao, nomeArq, linha;

            Console.WriteLine("Alessandra Faria 573831");
            Console.WriteLine("Menu");
            Console.WriteLine("1. Incluir um contribuinte.");
            Console.WriteLine("2. Excluir um contribuinte.");
            Console.WriteLine("3. Exibir os dados de um contribuinte: CPF/CNPJ, nome, endereço e salario/faturamento");
            Console.WriteLine("4. Calcular e exibir o imposto a ser pago por um contribuinte.");
            Console.WriteLine("5. Imprimir uma relação dos contribuintes Pessoa Física cadastrados, mostrando os dados:CPF, nome e endereço.");
            Console.WriteLine("6. Imprimir uma relação dos contribuintes Pessoa Jurídica cadastrados, mostrando os dados: CNPJ, nome e endereço.");
            Console.WriteLine("7. Sair do programa.");
            opcao = Console.ReadLine();

            while (opcao != "7")
            {
                switch (opcao)
                {
                    case "1":
                        //Console.WriteLine("digite o nome do arquivo ");
                        //nomeArq = Console.ReadLine();

                        //FileInfo fi = new FileInfo(nomeArq);
                        //StreamReader entrada = new StreamReader(nomeArq); //abrir o arquivo para leitura

                        //for ( j = 0; j < fi.Length; j++)
                        //{
                        //    linha = entrada.ReadLine();     //ler 1a linha
                        //    while (linha != null)           //enquanto houver dados...
                        //    {
                        //        string[] separa = linha.Split(',');
                        //        linha = entrada.ReadLine(); //ler proxima linha
                        //        j++;
                        //    }
                        // }
                        Console.WriteLine("Digite o nome do contrinuite");
                        string nome = Console.ReadLine();
                        Console.WriteLine("Digite o Endereço do contrinuite");
                        string endereço = Console.ReadLine();
                        Console.WriteLine("O contribuite é pessoa fisica(1) ou juridica (2)?");
                        string op2 = Console.ReadLine();
                            switch (op2)
                            {
                                case 1:
                                  Console.WriteLine("pessoa fisica");
                                  Console.WriteLine("qual o valor do salario do contribuinte");
                                  double salario = Convert.ToDouble(Console.ReadLine());
                                  Console.WriteLine("qual o numero do cpf  do contribuinte");
                                  string cpf = Console.ReadLine();

                                lst[k] = new PFisica(nome , endereço,salario,cpf );
                                k++;
                                break;

                                case 2:
                                Console.WriteLine("pessoa juridica");
                                Console.WriteLine("qual o valor do faturamento do contribuinte");
                                double faturamento = Convert.ToDouble(Console.ReadLine());
                                Console.WriteLine("qual o numero do cnpj do contribuinte");
                                string cnpj = Console.ReadLine();
                                lst[k] = new PJuridica(nome, endereço, faturamento, cnpj);
                                k++;

                                break;
                        }   
                        
                       


                        break;
                        
                }
                Console.WriteLine("Alessandra Faria 573831");
                Console.WriteLine("Menu");
                Console.WriteLine("1. Incluir um contribuinte.");
                Console.WriteLine("2. Excluir um contribuinte.");
                Console.WriteLine("3. Exibir os dados de um contribuinte: CPF/CNPJ, nome, endereço e salario/faturamento");
                Console.WriteLine("4. Calcular e exibir o imposto a ser pago por um contribuinte.");
                Console.WriteLine("5. Imprimir uma relação dos contribuintes Pessoa Física cadastrados, mostrando os dados:CPF, nome e endereço.");
                Console.WriteLine("6. Imprimir uma relação dos contribuintes Pessoa Jurídica cadastrados, mostrando os dados: CNPJ, nome e endereço.");
                Console.WriteLine("7. Sair do programa.");
                opcao = Console.ReadLine();
            }
        }
       
    }

        public abstract class Contribuinte
    {
        protected string nome;
        protected string endereco;
        public string getNome()
        {
            return nome;
        }
        abstract public double calcImposto();

}
    public class PFisica : Contribuinte
    {
        protected String cpf;
        protected double salario;
        public PFisica(String n, string end, double sal, String c)
        {
            cpf = c;
            salario = sal;
            base.nome = n;
            base.endereco = end;
        }
        public override double calcImposto()
        {
            double percentual = 0;
            if ((salario>0)&&(salario<=1400))
            {
                 percentual = 0;
            }
            else if((salario>1400)&&(salario<=2100)){
                percentual = (salario * 0.1)-100;
            }
            else if ((salario > 2100) && (salario <= 2800))
            {
                percentual = (salario * 0.15)-270;
            }
            else if ((salario > 2800) && (salario <= 3600))
            {
                percentual = (salario * 0.25)-500;
            }
            else
            {
                percentual = (salario * 0.3)-700;
            }
            return percentual;
        }
    }
    public class PJuridica : Contribuinte
    {
        protected String cnpj;
        protected double faturamento;
        public PJuridica(String n, string end, double f, String c)
        {
            cnpj = c;
            faturamento = f;
            base.nome = n;
            base.endereco = end;
        }
        public override double calcImposto()
        {
            double percentual = 0.1 * faturamento;
            return percentual;
        }
    }


}