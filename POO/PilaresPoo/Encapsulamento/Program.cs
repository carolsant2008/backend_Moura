using Encapsulamento;

// ContaBancaria contaCacau = new ContaBancaria();
// ContaBancaria contaMaria = new ContaBancaria(1500);

// contaCacau.Depositar (-100);
// contaCacau.Depositar(20);
// contaCacau.Sacar(-200);
// contaMaria.Sacar(300);

// Console.WriteLine();


// Console.WriteLine($"Saldo atual da cacau: R${contaCacau.GetSaldo()}");
// Console.WriteLine($"Saldo atual da Maria: R${contaMaria.GetSaldo()}");


  
        Carro c1 = new Carro();

      
        c1.DefinirMarca("Toyota");
        c1.DefinirModelo("Corolla");

       
        c1.Acelerar(30);
        c1.Acelerar(20);
        c1.Frear(15);
        c1.Frear(50); 

       
        Console.WriteLine("Marca: " + c1.ObterMarca());
        Console.WriteLine("Modelo: " + c1.ObterModelo());
        Console.WriteLine("Velocidade Atual: " + c1.ObterVelocidade() + " km/h");

        Console.ReadLine();
    
