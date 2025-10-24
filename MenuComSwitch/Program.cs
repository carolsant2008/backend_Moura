int opcao;
do
{
    Console.Clear();
    Console.WriteLine($"----------------------------------------------------------------------");
    Console.WriteLine($"                        Bem vindo                                     ");
    Console.WriteLine($"                           ao                                         ");
    Console.WriteLine($"                       Jacareca Food                                  ");
    Console.WriteLine($"----------------------------------------------------------------------");
    Console.WriteLine($"");

    Console.WriteLine($"            Escolha uma opção do menu abaixo        ");
    Console.WriteLine($"");


    Console.WriteLine($"1- Hot Holl ..................... 29,90");

    Console.WriteLine($"2- Temaki ....................... 38,90");

    Console.WriteLine($"3- Sashimi ...................... 67,90");

    Console.WriteLine($"4- Yakisoba ..................... 35,90");

    Console.WriteLine($"5- Guioza ....................... 49,90");

    Console.WriteLine($"6- Shimeji ...................... 50,90");
    Console.WriteLine($"0- Sair");
    Console.Write($"Opção:");
    opcao = int.Parse(Console.ReadLine());

    switch (opcao)
    {
        case 0:
            Console.WriteLine($"Saindo...");

            break;
        case 1:
            HotHoll();
            break;
        case 2:
            Temaki();
            break;
        case 3:
            Shimeji();
            break;
        case 4:
            Yakisoba();
            break;
        case 5:
            Guioza();
            break;
        case 6:
            Shimeji();
            break;
        default:
            Console.WriteLine($"Opção inválida");
            break;
    }

    Console.WriteLine($"Digite <Enter> para continuar...");
    Console.ReadLine();

} while (opcao != 0);

void HotHoll()
{
       Console.WriteLine($"Boa escolha, vamos reparar o seu Hot Holl com carinho");
}

void Temaki()
{
     Console.WriteLine($"Boa escolha, vamos reparar o seu Temaki com carinho");
}

void Sashimi()
{
      Console.WriteLine($"Boa escolha, vamos reparar o seu Sashimi com carinho");
}

void Yakisoba()
{
    Console.WriteLine($"Boa escolha, vamos reparar o seu Yakisoba com carinho");
}

void Guioza()
{
    Console.WriteLine($"Boa escolha, vamos reparar o seu Guioza com carinho");
}

void  Shimeji()
{
     Console.WriteLine($"Boa escolha, vamos reparar o seu Shimeji com carinho"); 
}
