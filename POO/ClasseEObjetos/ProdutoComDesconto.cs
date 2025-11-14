namespace ClasseEObjetos
{
    public class Produto
    {
        public string Nome;
        public double Preco;

        public void AplicarDesconto(double percentual)
        {
            double desconto = Preco * (percentual / 100);
            Preco -= desconto;
            Console.WriteLine($"Desconto de {percentual}% aplicado ao produto '{Nome}'.");
            Console.WriteLine($"Novo preço: R${Preco}\n");
        }
    }
}

