--Comando para criar tabelas e vendas

CREATE table Vendas (
	id INT PRIMARY KEY,
	DataCompra NVARCHAR(10),
	Tipo NVARCHAR(25),
	Marca NVARCHAR(25),
	Faturamento DECIMAL(5,2),
	Lucro DECIMAL(5,2)
);
go