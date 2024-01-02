//Caminho para a classe; o namespace:
using projeto.Models;

Console.WriteLine("Digite uma letra");
string letra = Console.ReadLine();


//RECONHECIMENTO DE LETRAS: SE É OU NÃO UMA VOGAL
//ESTE MODO UTILIZA MUITAS LINHAS E TRATA-SE DE UMA CODIFICAÇÃO CANSATIVA E REPETITIVA
// if (letra == "a")
// {
//     Console.WriteLine("Vogal");
// }
// else if (letra == "e")
// {
//     Console.WriteLine("Vogal");
// }
// else if (letra == "i")
// {
//     Console.WriteLine("Vogal");
// }
// else if (letra == "o")
// {
//     Console.WriteLine("Vogal");
// }
// else if (letra == "u")
// {
//     Console.WriteLine("Vogal");
// }
// else
// {
//     Console.WriteLine("Não é uma Vogal");
//}


//RECONHECIMENTO DE LETRAS: SE É OU NÃO UMA VOGAL
//ESTE MODO UTILIZA POUCAS LINHAS, CODIFICAÇÃO MAIS LIMPA: 
// if (letra == "a" ||
//     letra == "e" ||
//     letra == "i" ||
//     letra == "o" ||
//     letra == "u")
// {
//     Console.WriteLine("Vogal");
// }
// else
// {
//     Console.WriteLine("Não é uma Vogal");    
// }

//RECONHECIMENTO DE LETRAS: SE É OU NÃO UMA VOGAL USANDO SWITCH CASE:
//OPERADOR DE SELEÇÃO:
switch (letra)
{
    case "a":
    case "e":
    case "i":
    case "o":
    case "u":
        Console.WriteLine("Vogal");
        break;

    default:
        Console.WriteLine("Não é uma vogal");
        break;
}