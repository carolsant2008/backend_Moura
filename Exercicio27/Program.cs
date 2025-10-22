int qntUsuario = 0;
int contador = 1;
Console.WriteLine("Quantos Numeros Voce Quer Digitar?");
qntUsuario = int.Parse(Console.ReadLine());

while (contador <= qntUsuario)
{
    Console.WriteLine($"Digite um numero");
    int batata = int.Parse(Console.ReadLine());
    if (batata % 2 == 0)
    {
        Console.WriteLine($"Numero Digitado é par: {batata}");
    }
    contador++;
}
