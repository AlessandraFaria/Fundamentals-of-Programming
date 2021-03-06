
# 3.2 
Fazer um programa codificado em C# que implemente a classe Conta, com as seguintes
especificações:

## 3.2.1 Atributos obrigatórios da classe Conta::

```private String titular; // nome do titular da conta

private int agencia; // número da agência da conta

private int numConta; // número da conta

private static int cont = 0; //contador de contas existentes

private double saldo; // saldo atual da conta.
```
Deve-se usar, obrigatoriamente, propriedades com acessores get e set para dados privados.

## 3.2.2 Métodos obrigatórios da classe Conta:

```
public Conta ( int agencia, int numero, string titular ) { // construtor

public Excluir_Conta(int numero_conta);

public void Deposita(double valor);

public void Retira (double valor);

}
```
## 3.2.3 Propriedades obrigatótias (get e set para dados privados).

```double Saldo { get };
```
## 3.2.4 Os dados das contas devem ser armazenados em vetor estático do tipo abstrato Conta com
limite de 100 clientes, ou seja:
```
const int MAXCONTAS = 100; // número máximo de contas suportado

static Conta[ ] vetContas = new Conta[MAXCONTAS]; //vetor de contas
```
## 3.2.5 O programa deve apresentar inicialmente na tela um menu com as seguintes opções:

1. Criar uma nova conta.
2. Excluir uma conta existente.
3. Depositar em uma conta.
4. Sacar de uma conta.
5. Imprimir o saldo de uma conta.
6. Imprimir a relação das contas existentes listando o número e o nome do titular da conta
7. Buscar conta e mostrar informações
8. Sair do programa

## 3.2.6 O programa deve obter a opção do usuário, chamar o método correspondente, apresentar o
resultado e sempre voltar ao menu inicial, exceto quando for selecionada a opção 8 (Sair do
programa).

## 3.2.7 Usar as técnicas de encapsulamento e ocultação 

## 3.2.8 Implemente a classe Testa_Contas para criar objetos da classe Conta e simular seu uso.


# 4.1

Utilizando obrigatoriamente o conceito de herança, fazer programa codificado em C# que

atenda os seguintes requisitos:

Uma loja comercial tem 2 tipos de funcionários: vendedores e administrativos. Para todos a

empresa precisa ter o registro do nome e RG do funcionário. Os vendedores têm um salário base,

mas ganham também comissão de suas vendas. Os administrativos têm um salário fixo, mas podem

ganhar horas extras adicionais.

Os vendedores devem ter um método que acumule o total de vendas durante o mês e um método

que imprima seu salário total considerando que a comissão é de 5%. Para os administrativos as

horas extras é que são acumuladas e pagas com o valor de um centésimo do salário por hora. Nos

dois casos, o método que imprime o salário a receber zera os valores acumulados.

Outras especificações adicionais podem ser fornecidas pelo professor durante as aulas

