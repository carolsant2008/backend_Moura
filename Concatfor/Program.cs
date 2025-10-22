//ao final, vamos exibir o nome do usuario completo

int qtdLetras = 0;

Console.WriteLine($"Ola usuario, quantas letras tem o seu nome?");
qtdLetras = int.Parse(Console.ReadLine());
string nome = "";

for (int i = 1; i <= qtdLetras; i++)
{
    Console.WriteLine($"Qual eh a {i}ª letra");
    nome += Console.ReadLine();
}

Console.WriteLine($"Qual é o seu nome: {nome}");

