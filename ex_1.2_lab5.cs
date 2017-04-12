using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
namespace lab_5._1_ex12
{
    class Menu
    {
        static PFisica chamaPF = new PFisica();
        static PJuridica chamaPJ = new PJuridica();
        static void Main(string[] args)
        {
            int i = 0;
            int j = 0;
            string opcao, nomeArq;
            //double venda;
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
                        Console.WriteLine("digite o nome do arquivo ");

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
            // inicialização das varáveis de instância
        }
        public double calcImposto()
        {
            // Cálculo do imposto
        }
    }
    public class PJuridica : Contribuinte
    {
        protected String cnpj;
        protected double faturamento;
        public PJuridica(String n, string end, double f, String c)
        {
            // inicialização das varáveis de instância
        }
        public double calcImposto()
        {
            // Cálculo do imposto
        }
    }


}