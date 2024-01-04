//Caminho para a classe; o namespace:
using projeto.Models;

Calculadora calculo = new Calculadora();

calculo.Somar(30, 15);
calculo.Subtrair(30, 15);
calculo.Multiplicar(30, 15);
calculo.Dividir(30, 15);
calculo.Potencia(3, 3);
calculo.Seno(30);
calculo.Cosseno(30);
calculo.Tangente(30);
calculo.RaizQuadrada(9);

//Incrementando números:
int numero = 10;

Console.WriteLine("Incremetando o 10");
numero++;
Console.WriteLine(numero);

//Decrementando números:
int decr = 10;

Console.WriteLine("Decremetando o 10");
decr--;
Console.WriteLine(decr);

