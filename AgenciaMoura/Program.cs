using System.Runtime.InteropServices;

string[] nomes = new string[10];//array tamanho 10 - de 0 a 9
float[] saldos = new float[10];//array tamanho 10 - de 0 a 9
int totalClientes = 0;

int opcao;

do
{
    Console.Clear();
    Console.WriteLine(@$"=== SISTEMA BANCÁRIO SIMPLES ===
1. Cadastrar Cliente
2. Depositar
3. Sacar
4. Transferir
5. Listar Clientes
0. Sair");
    Console.Write($"Digite a opção: ");
    opcao = int.Parse(Console.ReadLine());

    // switch
    switch (opcao)
    {
        case 0:
            Console.WriteLine($"Encerrando o programa ...");
            break;
        case 1:
            CadastrarCliente();
            break;
        case 2:
            Depositar();
            break;
        case 3:
            Sacar();
            break;
        case 4:
            Transferir();
            break;
        case 5:
            ListarCliente();
            break;
        default:
            Console.WriteLine($"Opção Inválida");
            break;
    }

    Console.WriteLine("Pressione ENTER para continuar...");
    Console.ReadLine();

} while (opcao != 0);

void CadastrarCliente()
{
    // validar se há espaço pra cadastrar no array
    if (totalClientes >= 10)
    {
        Console.WriteLine($"Limite de clientes atingido!");
        return;
    }

    // cadastrar o cliente no array
    Console.Write($"Nome do cliente: ");
    nomes[totalClientes] = Console.ReadLine();//cadastra o nome do cliente
    saldos[totalClientes] = 0;//inicia o saldo zerado
    totalClientes++;//incrementa a variável de controle de clientes
    Console.WriteLine("Cliente cadastrado com sucesso!");
}

void Depositar()
{
    int idCliente = BuscarCliente();
    if (idCliente == -1)
    {
        return;
    }

    Console.Write($"Valor para deposito:");
    float valor = float.Parse(Console.ReadLine());
    saldos[idCliente] += valor;
    Console.WriteLine($"Deposito de R$ {valor:f2} realizado");
}
void Sacar()
{
    int idCliente = BuscarCliente();
    if (idCliente == -1)
    {
        return;
    }

    Console.Write($"Valor para saque: ");
    float valor = float.Parse(Console.ReadLine());

    if (saldos[idCliente] >= valor && valor > 0)
    {
        saldos[idCliente] -= valor;
        Console.WriteLine($"Saque realizado com sucesso");
    }
    else
    {
        Console.WriteLine($"Saldo insuficiente!");
    }
}
void Transferir()
{
    Console.WriteLine($"== Transferencia ==");
    Console.Write($"Conta de origem: ");
    int idOrigem = BuscarCliente();

    if (idOrigem == -1) return;

    Console.Write($"Conta de Destino: ");
    int idDestino = BuscarCliente();

    if (idDestino == -1) return;

    Console.Write($"Valor para transferir: ");
    float valor = float.Parse(Console.ReadLine());

    if (saldos[idDestino] >= valor && valor > 0)
    {
        saldos[idOrigem] -= valor;
        saldos[idDestino] += valor;
        Console.WriteLine($"Transferencia concluida");

    }

    else
    {
        Console.WriteLine($"Saldo insuficiente ");
    }

}
void ListarCliente()
{
    Console.WriteLine("== Lista de Clientes ==");
    for (int i = 0; i < totalClientes; i++)
    {
        Console.WriteLine($"{i} - {nomes[i]} | Saldo: R$ {saldos[i]}");
    }

}

int BuscarCliente()
{
    ListarCliente();
    Console.Write($"Digite o numero do cliente");
    int idCliente = int.Parse(Console.ReadLine());
    if (idCliente < 0 || idCliente >= totalClientes)
    {
        Console.WriteLine($"Cliente nao encontrado");
        return -1;   
    }


    return idCliente; 
}
