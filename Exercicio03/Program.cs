Console.Write("Lado A: ");
double a = double.Parse(Console.ReadLine());

Console.Write("Lado B: ");
double b = double.Parse(Console.ReadLine());

Console.Write("Lado C: ");
double c = double.Parse(Console.ReadLine());

if(a == b && b == c)
{
    Console.WriteLine("Triângulo Equilátero");
}
else if(a == b || b == c || a == c)
{
    Console.WriteLine("Triângulo Isósceles");
}
else
{
    Console.WriteLine("Triângulo Escaleno");
}
