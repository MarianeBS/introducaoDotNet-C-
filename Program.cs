//Caminho para a classe; o namespace:
using projeto.Models;

int quantidadeEstoque = 10;
int quantidadeCompra = 0;
bool possivelVenda = quantidadeCompra > 0 && quantidadeEstoque >= quantidadeCompra;

Console.WriteLine($"Quantidade em estoque: {quantidadeEstoque}");    
Console.WriteLine($"Quantidade na compra: {quantidadeCompra}");    
Console.WriteLine($"É possível realizar a venda?: {possivelVenda}");    

// = Operador de atribuição
// == Comparação

if (quantidadeCompra == 0)
{
    Console.WriteLine("Venda inválida");
}

else if (possivelVenda)
{
    Console.WriteLine("Venda realizada com sucesso!");    
}
else
{
    Console.WriteLine("Quantidade insuficiente no estoque!");
}