// DATEtIME
//TimeSpan

var horario = DateTime.Now;

DateTime data1 = new(1991, 8, 27);
DateTime data2 = new DateTime(1993, 6, 7);

var data = DateTime.Compare(data1, Data2); //compara
var dataadd = Data1.AddDays(1); //add dias 

//Declaração de variáveis
int segundos, minutos, horas;

//Entrada de dados 
Console.WriteLine("Digite a duração em segundos: ");
int totalsegundos = int.Parse(Console.ReadLine());

//Processamento de dados
horario = totalsegundos / 3600;
minutos = (totalsegundos % 3600) / 60;
segundos = (totalsegundos % 3600) % 60;

//Saída de dados
Console.WriteLine($"{hora}:{minutos}:{segundos}");
