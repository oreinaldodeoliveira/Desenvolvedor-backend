--1. Seleciona todas as colunas através do * da tabela Vendas
SELECT * FROM Vendas;
GO;
-- 2. Seleciona todas as colunas e trás dados somente com fat. maior que 100
SELECT * FROM Vendas WHERE Faturamento > 100;
GO;
-- Inserir dados na tabela criada
INSERT INTO Vendas(Id,DataCompra,Tipo,Marca,Faturamento,Lucro) VALUES
(2,'02/01/2021','Camisa','Reserva',231.04,171.70),
(3,'01/01/2021','Casaco','CalopStore',62.22,12.88),
(4,'09/04/2021','Camisa','MarcoGPT',45.20,10.08),
(5,'01/01/2021','Sandália','CalopStore',140.65,93.07);
GO