using System;

//Declaração de variaveis
int totalsegundos, horas, minutos, segundos;

//Entrada de dados 
Console.WriteLine("Digite a duração em segundos: ");
Totalsegyundos = int.Parse(Console > ReadLine());

TimeSpan duracao = TimeSpan.FromSeconds(totalsegundos);

//Processamneto de dados
horas = (int)duracao.TotalHours;
minutos = duracao.minutos;
segundos = duracao.Seconds;

//saida de dados
Console.WriteLine($"{horas}: {minutos}: {segundos} ");
/*
  
 /* 

CConsole.WriteLine(1 / 1.0);

Console.WriteLine("Digite um numero");
var x = int.Parse(Console.ReadLine());
Console.writeLine("Digitar um numero");
var x = int.Parse(Console.ReadLime());

x = y
y = z

Console.writeLine(x + y);
