using CasasBahia.Classes.Contextos;

ProdutoContexto contexto = new ProdutoContexto();

contexto.Database.EnsureCreated();

bool continuar = true;

while (continuar)
{
    Console.WriteLine("-- Menu do almoxarifado --");
    Console.WriteLine("1. Adicionar Produto");
    Console.WriteLine("2. Listar Produtos");
    Console.WriteLine("3. Sair");
}