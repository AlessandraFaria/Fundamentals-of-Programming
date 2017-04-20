# Ex1.2 

Escrever um programa codificado em C# para utilizar os conceitos de herança e classes abstratas
para calcular o Imposto de Renda de uma coleção de contribuintes, que podem ser pessoas físicas
ou pessoas jurídicas.

### 1.2.1 O cálculo do IR deve ser feito da seguinte maneira:

Pessoa Jurídica
O imposto deve corresponder a 10% da renda bruta da empresa.

Pessoa Física
O imposto deve ser calculado de acordo com a seguinte tabela:

Renda Bruta Alíquota Parcela a Deduzir

R$ 0,00 a R$ 1.400,00 0% R$ 0,00

R$ 1.400,01 a R$ 2.100,00 10% R$ 100,00

R$ 2.100,01 a R$ 2.800,00 15% R$ 270,00

R$ 2.800,01 a R$ 3.600,00 25% R$ 500,00

R$ 3.600,01 ou mais 30% R$ 700,00

###  1.2.2 As classes a seguir devem ser usadas conjuntamente com este enunciado. Elas contêm parte
do código necessário à implementação deste exercício. Deve-se completá-las nos pontos indicados,
de acordo com os objetivos do exercício.

```public abstract class Contribuinte {

protected string nome;

protected string endereco;

public string getNome( ){

return nome;

}

abstract public double calcImposto();

8

}

public class PFisica: Contribuinte {

protected String cpf;

protected double salario;

public PFisica(String n,string end, double sal,String c){

// inicialização das varáveis de instância

}

public double calcImposto() {

// Cálculo do imposto

}

}

public class PJuridica: Contribuinte {

protected String cnpj;

protected double faturamento;

public PJuridica(String n,string end, double f,String c){

// inicialização das varáveis de instância

}

public double calcImposto(){

// Cálculo do imposto

}

}
```

### 1.2.3 Os dados das contas devem ser armazenados em vetor estático do tipo abstrato Contribuinte
com limite de 100 ontribuintes, ou seja:

```
const int MAXCONTRIBUINTES = 100; // número máximo de contas suportado

static Contribuinte [ ]lst = new Contribuinte [MAXCONTRIBUINTES]; //vetor de contribuintes
```

### 1.2.4 O programa deve apresentar inicialmente na tela um menu com as seguintes opções:

1. Incluir um contribuinte.

2. Excluir um contribuinte.

3. Exibir os dados de um contribuinte: CPF/CNPJ, nome, endereço e salario/faturamento.

4. Calcular e exibir o imposto a ser pago por um contribuinte.

5. Imprimir uma relação dos contribuintes Pessoa Física cadastrados, mostrando os dados:

CPF, nome e endereço.

6. Imprimir uma relação dos contribuintes Pessoa Jurídica cadastrados, mostrando os

dados: CNPJ, nome e endereço.

7. Sair do programa

### 1.2.5 O programa deve obter a opção do usuário, chamar o método correspondente, apresentar o
resultado e sempre voltar ao menu inicial, exceto quando for selecionada a opção 7 (Sair do
programa).

### 1.2.6 O programa deve, obrigatoriamente, armazenar e usar os dados dos contribuintes no

seguinte formato (obrigatório).

//Arquivo exemplo:

// (tipo_contribuinte, CPF_CNPJ, nome, endereço, salario/faturamento):

"PF", "11111","Joao Santos","Rua abc, 123",3000.00

"PJ", "10055","Lojas AA","Rua Hum, 111",150000.00
