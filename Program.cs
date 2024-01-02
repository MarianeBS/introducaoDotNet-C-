//Caminho para a classe; o namespace:
using projeto.Models;

string apresentacao = "Olá, seja bem-vindo!";
int quantidade = 1;
double altura = 1.80;
decimal preco = 1.80M;
bool condicao = true;
DateTime dataAtual = DateTime.Now;
//DateTime adicionando 5 dias:
DateTime dataCincoDias = DateTime.Now.AddDays(5);

int a = 10;
int b = 20;
int c = a + b;

//As duas sintaxes abaixo corresponderão ao mesmo resultado:
//c = c + 5;
//c += 5;

//Cast ou Casting
//Convertendo uma String em Inteiro:
//Convert - Conversão para inteiros, podendo conter o valor nulo (null) 
int d = Convert.ToInt32("5");

int e = int.Parse("5");

//Para converter inteiros em strings:
//int inteiro = 5;
//string a = inteiro.ToString();

//Para converter strings em inteiros:
//string h = "5";
//int i = Convert.ToInt32(h);

//Cast Simples - Conversão automática:
//Um inteiro cabe em um double
//int f = 5;
//double g = f;


Console.WriteLine(apresentacao);
Console.WriteLine("Valor da variável quantidade: " + quantidade);
Console.WriteLine("Valor da variável altura: " + altura.ToString("0.00"));
Console.WriteLine("Valor da variável preço: " + preco);
Console.WriteLine("Valor da variável condição: " + condicao);
Console.WriteLine("Data atual: " + dataAtual);
Console.WriteLine("Data atual com mais cinco dias: " + dataCincoDias);
//Apresentando modelo com apenas a data, utilizando o DateTime:
Console.WriteLine("Data atual com mais cinco dias s/ horário: " + dataCincoDias.ToString("dd/MM/yyyy"));
//Apresentando modelo sem os milissegundos, utilizando o DateTime:
Console.WriteLine("Data atual com mais cinco dias s/ milissegundos: " + dataCincoDias.ToString("dd/MM/yyyy HH:mm"));
//Resultado da soma:
Console.WriteLine("Resultado da soma: " + c);
//Conversão de String para Int:
Console.WriteLine("Número convertido: " + d);
//Conversão de String para Int com Parse:
Console.WriteLine("Número convertido: " + e);



//Instância da classe Pessoa:
//Pessoa = classe (como a planta de uma casa)
//p = variável (endereço na memória)
//new Pessoa() = (como a planta de uma casa já construída)
Pessoa p = new Pessoa();

//Atribuindo valores às variáveis:
p.Nome = "Mariane Souza";
p.Idade = 18;

//Chamando o método Apresentar:
//O ponto "." representa a continuidade de uma ação
p.Apresentar();


