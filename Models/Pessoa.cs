namespace projeto.Models
{
    //É recomendável que o nome do arquivo obedeça ao nome da classe. 
    public class Pessoa
    {
        //Definindo propriedades:
        //Nunca abreviar nomes de propriedades (não recomendável).
        public string Nome { get; set; }
        public int Idade { get; set; }   

        //Criando o método/ação Apresentar:
        public void Apresentar()
        {

            Console.WriteLine($"Olá, meu nome é {Nome}, e tenho {Idade} anos");

            //Para realizar quebra de linha para melhor organização do código:
            //Console.WriteLine($"Olá, meu nome é" + 
            //$"{Nome}, e tenho {Idade} anos");

            //Para pular uma linha no texto:
            //Console.WriteLine($"Olá, meu nome é {Nome}, \n e tenho {Idade} anos");
        }

    }
}