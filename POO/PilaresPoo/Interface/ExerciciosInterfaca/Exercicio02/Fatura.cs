namespace Exercicio02
{
    public class Fatura : IImprimivel
    {
        public string Devedor = "";

        public string Credor = "";

        public float Valor = 0;

        public int DiasAtraso = 0;

        private float Juros = 0.10f;

        public Fatura (string nomeDevedor, string nomeEmpresa, float valorFatura, int qtdDiasAtraso)
        {
            Devedor = nomeDevedor;
            Credor = nomeEmpresa;
            Valor = valorFatura;
            DiasAtraso = qtdDiasAtraso;
        }
        public void CalcularValorDivida()
        {
            if (DiasAtraso > 0)
            {
               Valor = Valor + DiasAtraso * Juros;
            }

            if (DiasAtraso >= 5)
            {
                Console.WriteLine($"Dívida encaminhada para o SERASA");
                
            }
        }
        public void imprimir()
        {
           Console.WriteLine($@"
           Credor:{Credor}
           Devedor:{Devedor}
           Dias de atraso:{DiasAtraso}
           Juros: R${Juros * DiasAtraso}
           Valor total: {Valor}
           ");
           
        }

    }
}