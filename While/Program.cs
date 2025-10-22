int contador = 1;

Console.WriteLine($"Quantasvezes vc quer rodar o while?");

int qtdVezes = int.Parse(Console.ReadLine());

while (contador <= qtdVezes)
{
    Console.WriteLine($"Contador é: {contador}");
    contador++;
}
