//eclaração de variáveis
const int senha  = 2002;

//Entrada de dados
Console.WriteLine("Digite a senha: ");
int n = int.Parse(Console.ReadLine());

while (senha != n)
{
    Console.WriteLine("Senha Incorreta, tente novamente: ");
    n = int.Parse(Console.ReadLine());
}
    Console.WriteLine("Acesso permitido! ");