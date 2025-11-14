using ExercicioPolimorfismo;

PagamentoPix compraPix = new PagamentoPix();
compraPix.ValorCompra = 15000;
float valorPagar = compraPix.CalcularTotal();
Console.WriteLine($"Produto: Smartphone ");
Console.WriteLine($"Preco: {compraPix.ValorCompra}");
Console.WriteLine($"Forma de pagamento: pix");
Console.WriteLine($"agamento com desconto: {valorPagar}");


PagamentoCartao compraCartao = new PagamentoCartao();
compraCartao.ValorCompra = 50;

Console.WriteLine($"Produto: Caneca");
Console.WriteLine($"Preco: {compraPix.ValorCompra}");
Console.WriteLine($"Forma de pagamento: Cartao");

Console.WriteLine($"agamento com Acrescimo: {compraCartao.CalcularTotal()}");