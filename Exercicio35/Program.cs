
using System.Diagnostics.Contracts;
        Console.Write("Digite o número de repetições: ");
int x = int.Parse(Console.ReadLine());
int n1, n2;
int contador = 1;
while (contador <= x)

     {
    Console.WriteLine($"Digite o primeiro numero:");
    n1 = int.Parse(Console.ReadLine());
    Console.WriteLine($"Digite o segundo numero:");
    n2 = int.Parse(Console.ReadLine());

    if (n1 > n2)
    {
        Console.Write($"O numero {n1} eh maior que o {n2}:");
    }
    else if (n2 > n1)

    {
        Console.Write($"O numero {n1} eh maior que o {n2}:");
    }
    else
    {
        Console.Write($"O numero {n1} e o {n2} sao iguais (:0 :");
    }

    contador++;



}