using System.Diagnostics;
using System.Reflection;
using Exercicio02;
List<IImprimivel> documentos = new List<IImprimivel>();

//criar um menu 

int opcao;
do
{
    Console.Clear();
    Console.WriteLine($@"Menu com opecoes
    1) Cadastrar fatura 
    2) Cadastrar relatorio
    3) Cadastrar contrato
    4) Listar faturas
    5) Listar relatorios 
    6) Listar contratos 
    0) Sair 
    Escolha uma opecao:
    ");
    opcao = int.Parse(Console.ReadLine());
    switch (opcao)
    {
        case 1:
            Console.WriteLine($"Cadastrar faturas em desenvolvimento");
            break;
        case 2:
            Console.WriteLine($"Cadastrar relatorios em desenvolvimento ");
            break;
        case 3:
            Console.WriteLine($"Cadastrar contratos em desenvolvimento");
            break;
        case 4:
            Console.WriteLine($"Listar faturas em desenvolvimento");
            break;
        case 5:
            Console.WriteLine($"Listar relatorios em desenvolvimento");
            break;
        case 6:
            Console.WriteLine($"Listar contratos em desenvolvimento");
            break;
        case 0:
            Console.WriteLine($"Sair");
            break;

        default:
            Console.WriteLine($"Opcao invalida");
            break;
    }
Console.WriteLine($"Precione <ENTER> para continuar ");
Console.ReadLine();


} while (opcao != 0);

void CadastrarFaturas()
{
    Console.WriteLine($"Digite o nome do cliente devedor ");
    string dev = Console.ReadLine();

    Console.WriteLine($"Digite o nome da empresa ");
    string empresa = Console.ReadLine();

    Console.WriteLine($"Digite o valor da fatura  ");
    float valor = float.Parse(Console.ReadLine());

    Console.WriteLine($"Dias de atraso da fatura ");
    int qtdDiasAtraso = int.Parse(Console.ReadLine());

    Console.WriteLine($"Fatura cadastrada com sucesso!");
    
}

void CadastrarRelatorios()
{
    

    
}

void CadastrarCadastro()
{
    
}

void ListarFaturas()
{
    Console.WriteLine($"Listando Faturas:");
    foreach (var item in documentos)
    {
        if (item is Fatura)
        {
            item.imprimir();
        }
    }
}

void ListarRelatorios()
{
    
}

void ListarContratos()
{
    
}































//criar uma lista para faturas 
// List<Fatura> Listafaturas = new List<Fatura>();
// List<Relatorio> Listarelatorio = new List<Relatorio>();
// List<Contrato> Listacontrato = new List<Contrato>();
//  Fatura faturacacau = new Fatura();
// documentos.Add(faturacacau);

// Fatura faturaAle = new Fatura();
// documentos.Add(faturaAle);

//  Relatorio relatoriocacau = new Relatorio();
// documentos.Add(relatoriocacaucacau);

//  Relatorio relatorioAle = new Relatorio();
// documentos.Add(relatorioAle);

//  Contrato contratocacau = new Contrato();
// documentos.Add(contratocacau);

//  Contrato contratoAle = new Contrato();
// documentos.Add(contratoAle);

// //  faturacacau.imprimir();
// //  relatoriocacau.imprimir();
// //  contratocacau.imprimir();

// // listar dados da fatura 

// Console.WriteLine($"FATURAS");

// foreach (var fatura in documentos)
// {
//     if (fatura is Fatura)
//     {
//         fatura.imprimir();
//     }
// }

// Console.WriteLine($"RELATORIOS");

// foreach (var relatorio in documentos)
// {
//     if (relatorio is documentos)
//     {
//         relatorio.imprimir();
//     }
// }

// Console.WriteLine($"CONTRATOS");

// foreach (var contrato in documentos)
// {
//     if (contrato is documentos)
//     {
//         contrato.imprimir();
//     }
// }