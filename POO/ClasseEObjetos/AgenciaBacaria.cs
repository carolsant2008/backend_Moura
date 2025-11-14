namespace ClasseEObjetos
{
    public class AgenciaBacaria
    {
        public string Titular = "";

        public float Saldo;

        public void Depositar(float _valorSaque)
        {
            if (_valorSaque <= 0)
            {
                Console.WriteLine($"O valor do saldo deve ser maior do que R$ 0");
                return;
            }

            Saldo += _valorSaque;
            Console.WriteLine($"Depósito realizado. Novo Saldo: {Saldo}");
            
        }

        public void Sacar(float _valorSaque)
        {
            if (_valorSaque <= 0 && _valorSaque < Saldo)
            {
                Console.WriteLine($"Saldo Atual: {Saldo}");
                Console.WriteLine($"Não é possivel sacar este valor solicitado, por favor insira um valor válido");
                return;
            }

            Saldo -= _valorSaque;

            Console.WriteLine($"Saque realizado. Novo Saldo: {Saldo}");
            
        }
    }
}