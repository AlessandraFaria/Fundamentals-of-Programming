using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_4._1_ex3
{
    public class Funcionario
    {
        private string rg;
        private string nome;
        public Funcionario() { }

        public Funcionario(String nome, String rg)
        {//construtor
            this.nome = nome;
            this.rg = rg;
        }
        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }
        public string Rg
        {
            get { return rg; }
            set { rg = value; }
        }

    }

    public class Vendedor : Funcionario
    {
        double comicao;
        private double salarioTotal;

        public Vendedor()
        {
            comicao = 0;
            salarioTotal = 1200;
        }

        public double CalComi(double venda)
        {
            comicao = (venda * 5) / 100;
            salarioTotal = salarioTotal + comicao;
            return comicao;
        }

        public Double SalarioTotal
        {
            get { return salarioTotal; }
            set { salarioTotal = value; }
        }

    }

    public class Administrativo : Funcionario
    {
        double hExtra;
        double salarioAdmTotal;

        public Administrativo()
        {
            salarioAdmTotal = 3000;
        }

        public double HoraEx(double hora)
        {
            hExtra = hora * 0.01;
            salarioAdmTotal = salarioAdmTotal + hExtra;
            return hExtra;
        }

        public Double SalarioAdmTotal
        {
            get { return salarioAdmTotal; }
            set { salarioAdmTotal = value; }
        }
    }

    class Program
    {
        static Vendedor chamaVendedor = new Vendedor();
        static Administrativo chamaAdministrador = new Administrativo();
        //  static Funcionario chamaFuncionario;
        public static Vendedor[] vetFun = new Vendedor[20];
        public static Administrativo[] vetFunAdm = new Administrativo[20];
        static void Main(string[] args)
        {
            int i = 0;
            int j = 0;
            string opcao;
            double venda;

            Console.WriteLine("Menu RH");
            Console.WriteLine("1- Cadastrar funcionário novo");
            Console.WriteLine("2- Menu Vendedor");
            Console.WriteLine("3- Menu Administrativo");
            Console.WriteLine("4- Sair");
            opcao = Console.ReadLine();
            while (opcao != "4")
            {
                switch (opcao)
                {
                    case "1":
                        Console.Clear();
                        Console.WriteLine("1- Vendedor 2-Administrativo");
                        string op2 = Console.ReadLine();
                        if (op2 == "1")
                        {
                            vetFun[i] = new Vendedor();
                            Console.WriteLine("Digite o nome do novo funcionário");
                            vetFun[i].Nome = Console.ReadLine();
                            Console.WriteLine("Digite o RG do novo funcionário");
                            vetFun[i].Rg = Console.ReadLine();
                            vetFun[i] = chamaVendedor;
                            i++;
                        }
                        else if (op2 == "2")
                        {
                            vetFunAdm[j] = new Administrativo();
                            Console.WriteLine("Digite o nome do novo funcionário");
                            vetFunAdm[j].Nome = Console.ReadLine();
                            Console.WriteLine("Digite o RG do novo funcionário");
                            vetFunAdm[j].Rg = Console.ReadLine();
                            j++;
                        }
                        else { Console.WriteLine("Opção Inválida"); }
                        break;

                    case "2":
                        Console.Clear();
                        Console.WriteLine("1- Cadastrar nova venda");
                        Console.WriteLine("2- Imprimir salário total");
                        string op3 = Console.ReadLine();
                        if (op3 == "1")
                        {
                            Console.Write("Entre com o numero do Vendedor: ");
                            int numero_Vend = int.Parse(Console.ReadLine());
                            Console.WriteLine("Digite o valor da venda");
                            venda = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine("Comição salva: {0}", vetFun[numero_Vend - 1].CalComi(venda));
                        }
                        else if (op3 == "2")
                        {
                            Console.Write("Entre com o numero do Vendedor: ");
                            int numero_Vend = int.Parse(Console.ReadLine());
                            Console.WriteLine("O valor total do salário é: {0}", vetFun[numero_Vend - 1].SalarioTotal);
                        }
                        break;

                    case "3":
                        Console.Clear();
                        Console.WriteLine("1- Cadastrar Hora Extra");
                        Console.WriteLine("2- Imprimir salário total");
                        string op4 = Console.ReadLine();
                        if (op4 == "1")
                        {
                            Console.Write("Entre com o numero do Adiministrador: ");
                            int numero_Adm = int.Parse(Console.ReadLine());
                            Console.WriteLine("Digite a quantidade de horas extras");
                            double hora = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine("bônus salvo: {0}", vetFunAdm[numero_Adm - 1].HoraEx(hora));
                        }
                        else if (op4 == "2")
                        {
                            Console.Write("Entre com o numero do Adiministrador: ");
                            int numero_Adm = int.Parse(Console.ReadLine());
                            Console.WriteLine("O valor total do salário é: {0}", vetFunAdm[numero_Adm - 1].SalarioAdmTotal);
                        }
                        break;

                    default:
                        Console.Clear();
                        Console.WriteLine("Opção Inválida.");
                        break;
                }
                Console.WriteLine("Menu RH");
                Console.WriteLine("1- Cadastrar funcionário novo");
                Console.WriteLine("2- Menu Vendedor");
                Console.WriteLine("3- Menu Administrativo");
                Console.WriteLine("4- Sair");
                opcao = Console.ReadLine();
            }
        }
    }





}
