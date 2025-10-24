Console.Write("Gols do primeiro time: ");
int time1 = int.Parse(Console.ReadLine());

Console.Write("Gols do segundo time: ");
int time2 = int.Parse(Console.ReadLine());

if(time1 == time2)
{
    Console.WriteLine("Empate");
}
else if(time1 > time2)
{
    Console.WriteLine("Vitória do primeiro time");
}
else
{
    Console.WriteLine("Vitória do segundo time");
}

