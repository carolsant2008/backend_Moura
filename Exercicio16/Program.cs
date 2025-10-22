// // Uma empresa decide dar aumento aos funcionarios de acorco com o seu cargo, 
// // diosto na tabela abaixo:

// Produção - 6.5
// Admnistração - 7.5
// Diretoria - 12 

// Salario = salario * 1.065

// De acordo com a tabela acima faça um programa que receba o cargo e o salario de um funcionario e calcule e imprima o salario reajustado

string cargo;
double salario, salarioNovo = 0;

float saldo = 200.95f;
double saldo2 = 200.95f;

Console.WriteLine($"Digite o cargo do funcionario producao, administrativo ou diretoria");
cargo = Console.ReadLine();

Console.WriteLine($"Digite o salario do seu funcionario");
salario = double.Parse(Console.ReadLine());

if (cargo == "producao")
{
    salarioNovo = salario + (salario * 0.065);
}
else if (cargo == "administrativo")
{
   salarioNovo = salario + (salario * 0.075);
}
else if (cargo == "diretoria")
{
    salarioNovo = salario + (salario * 0.12);

}
else
{
    Console.WriteLine("Cargo inválido!");
    return;
}

Console.WriteLine($"O novo salário reajustado é: R$ {salarioNovo}");