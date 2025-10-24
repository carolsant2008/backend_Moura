Console.Write("Informe a média: ");
double media = double.Parse(Console.ReadLine());

Console.Write("Informe a frequência (%): ");
double freq = double.Parse(Console.ReadLine());

if(freq < 75)
{
    Console.WriteLine("Reprovado por frequência");
}
else
{
    if(media >= 7)
    {
        Console.WriteLine("Aprovado");
    }
    else if(media >= 3)
    {
        Console.WriteLine("Recuperação");
    }
    else
    {
        Console.WriteLine("Reprovado");
    }
}

