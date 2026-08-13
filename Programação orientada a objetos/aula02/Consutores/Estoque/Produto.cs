using System;
using System.Collections.Generic;
using System.Text;

namespace Estoque
{
    internal class Produto
    {
        //campos
        string nome;
        int quantidade;
        double preco;

        //construtor
        public Produto(string nome, int quantidade, double preco)
        {
            this.nome = nome;
            this.quantidade = quantidade;
            this.preco = preco;
        }

        public void AdicionarProdutos(int quantidade)
        {
            this.quantidade += quantidade;
        }

        public void RemoverProdutos(int quantidade)
        {
            this.quantidade -= quantidade;
        }

        public double ValorTotal()
        {
            return preco * quantidade;
        }

        public void ExibirInformacoes()
        {
            Console.WriteLine("Nome: {nome}");
           
        }
    }
}
