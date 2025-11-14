namespace ExercicioPolimorfismo
{
    public class PagamentoCartao : Pagamento 
    {
        private float acrescimo = 5.38f;

        public float ValorCompra;

        public override float CalcularTotal()
        {
           float valorAcrescimo = ValorCompra / 100 * acrescimo;

           return ValorCompra = ValorCompra + valorAcrescimo;
        }
    }
}