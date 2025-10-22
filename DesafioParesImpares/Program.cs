Console.WriteLine($"Quantos numeros vc quer digitar?");
int qtdNumeros = int.Parse (Console.ReadLine());
string pares = "Pares: ";
string impares = "Impares: ";

for (int i = 1; i < qtdNumeros; i++)
{
    Console.WriteLine($"Digite o {i} numero:");
    int numeroDigitado = int.Parse (Console.ReadLine());

    if (numeroDigitado % 2 == 0)
    { //é par?
        pares += numeroDigitado.ToString() + ", ";
    }
    else
    {
        impares += numeroDigitado.ToString() + ", ";
    }
}

Console.Clear();
Console.WriteLine($"Resultado");
Console.WriteLine();
Console.WriteLine(pares);
Console.WriteLine(impares);
