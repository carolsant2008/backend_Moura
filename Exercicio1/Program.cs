double salarioRecebido, totalGasto;

Console.WriteLine($"Informe o salario: ");
salarioRecebido = double.Parse(Console.ReadLine());
Console.WriteLine($"Iforme os gastos desse mes: ");
totalGasto = double.Parse(Console.ReadLine());

if (totalGasto > salarioRecebido)
{
      Console.WriteLine("Orçamento estourado!  >:(");
}
else
{
    Console.WriteLine("Gastos dentro do orçamento  :)");
}
 
