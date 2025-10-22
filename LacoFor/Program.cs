
Console.WriteLine($"Subindo");
for (int t = 0; t < 3; t++)
{
    Console.WriteLine($"Valor do t: {t}");
}

Console.WriteLine($"Descendo");
for (int t = 3; t >= 0; t--)
{
    Console.WriteLine($"Valor do t: {t}");
}

//============================================

Console.WriteLine();
Console.WriteLine($"for com variaveis de inicio e fim");

int inicio = 0, fim = 3;
for (int i = inicio; i <= fim; i++)
{
    Console.WriteLine($"Valor de t: {i}");
}