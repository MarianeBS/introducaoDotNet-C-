//Caminho para a classe; o namespace:
using projeto.Models;

//OPERADOR OR (Peper ||):
//Entrada liberada apenas se o usuário possuir mais de 18 anos OU possuir autorização:
bool maiorDeIdade = false;
bool possuiAutorizacao = true;

if (maiorDeIdade || possuiAutorizacao)
{
    Console.WriteLine("Entrada liberada");
}
else
{
    Console.WriteLine("Entrada NÃO liberada");    
}

//OPERADOR AND (&&):
//Todas as condições precisam ser verdadeiras.
bool presencaMinima = true;
double media = 7.5;

if (presencaMinima && media >= 7)
{
    Console.WriteLine("Aprovado");
}
else
{
    Console.WriteLine("Reprovado");    
}

//OPERADOR NOT (!)
//Trata-se da inversão do valor boleano.
bool choveu = false;
bool estaTarde = false;

//Se antes o boleano esperava true, com o !, ele passa a esperar false.
if (!choveu && !estaTarde)
{
    Console.WriteLine("Vou pedalar");
}
else
{
    Console.WriteLine("Vou pedalar outro dia");
}