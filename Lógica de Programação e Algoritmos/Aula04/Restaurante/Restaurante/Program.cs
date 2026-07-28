async Task Principal()
{
    Console.WriteLine("Pedido anotado");
    await Task.WhenAll(PrepararHambuguer(), PrepararBatata(), PrepararMilkshak());
    Console.WriteLine(" Pedido entregue");
}

async Task PrepararHambuguer()
{
    Console.WriteLine("Preparando Hamburguer...");
    Task.Delay(3000);
    Console.WriteLine("Hambuerguer pronto!");
}

async Task PrepararBatata()
{
    Console.WriteLine("Preparando Batat frita...");
    Task.Delay(2500);
    Console.WriteLine("Batata pronta!");
}

async Task PrepararMilkshak()
{
    Console.WriteLine("Preparando Milkshak...");
    Task.Delay(4000);
    Console.WriteLine("Milkshak pronto!");
}