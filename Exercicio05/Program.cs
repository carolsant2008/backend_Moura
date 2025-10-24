Console.Write("Quantidade de maçãs: ");
int qtd = int.Parse(Console.ReadLine());

double preco = qtd >= 12 ? 0.25 : 0.30;

double total = qtd * preco;

Console.WriteLine("Total da compra: R$ " + total);

