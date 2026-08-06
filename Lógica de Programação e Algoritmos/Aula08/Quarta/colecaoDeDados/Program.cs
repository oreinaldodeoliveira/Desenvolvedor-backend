//coleçãp de dados
/* -- srray -- 
int[] numeros = { 0, 1, 2, 10, 4 };
string[] nomes = { "Clodoaldo", "Kelvin", "cesar" };
char[] caracteres;
Console.WriteLine(numeros.Length);
Console.WriteLine(numeros[3]);
numeros[3] = 56;
Console.WriteLine(numeros[3]);
caracteres = new char[10];

/* -- Dicionário -- */ /*
Dictionary<string, double> salarios = new Dictionary<string, double>()
{
   {"Alicie", 1.73},
    {"Bob", 62.9},
    {"Cesar", 14}
};

Console.WriteLine(salarios["bob"]);
salarios.Add("SENAI", 8.96);
Console.WriteLine(slarios["SENAI"]);
salario.Remove("Alicie");

foreach (var item in salarios)
{
    if (salarios.ContainsKey("Bob"))
    { 
    Console.WriteLine("Bob esta na coleção");
}

 /* -- Listas -- */

List<int> lista1 = new List<int>();
lista1.Add(5600);
lista1.Add(600);
lista1.Add(0);
lista1.Add(50);
foreach (var item in lista1)
{
    Console.WriteLine(item);
}

lista1.Remove(600);

foreach (var item in lista1)
{
    Console.WriteLine(item);
}

lista1.Clear();

foreach (var item in lista1)
{
    Console.WriteLine(item);
}


/* -- Tuplas -- */
var pessoa = (nome: "Cesar", 34, 2.5, 'M');
Console.WriteLine(pessoa.Item1); // nome
Console.WriteLine(pessoa.Item2); //Idade
Console.WriteLine(pessoa.Item3); //Salario
Console.WriteLine(pessoa.Item4); //Genero
pessoa.Item1 = "Clodoaldo";
Console.WriteLine(pessoa.Item1); //Nome
Console.WriteLine(pessoa.Item1); //Idade
Console.WriteLine(pessoa.Item1); //Salario
Console.WriteLine(pessoa.Item1); //Genero
var pessoa2 = (Nome: "César", idade: 35);