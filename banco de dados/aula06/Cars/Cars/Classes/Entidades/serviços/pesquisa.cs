using Cars.Classes.Contextos;
using static System.Net.Mime.MediaTypeNames;

namespace Cars.Classes.serviços
{
    internal class pesquisa
    {
        //Campo
        EstoqueContexto contexto = new EstoqueContexto();
    }
}
if (moto.Equals(false) & carro.Equals(false))
{
    if (texto.IsNullOrEmpty())
    {
        dataGridView1.DataSource = contexto.Estoque.Select(e => new
        {
            e.Tipo,
            e.Modelo,
            e.Quantidade,
            Valor = e.Valor.ToString("C"),
        }).ToList();
    }

    else
    {
        dataGridView1.DataSource = contexto.Estoque.Select(e => new
        {
            e.Tipo,
            e.Modelo,
            e.Quantidade,
            Valor = e.Valor.ToString("C"),
        }).ToList();
    }
}
else if (moto)
{
    //Pesquisa por moto
    dataGridView1.DataSource = contexto.Estoque.Where(e => e.Tipo == 1).Select(e => new
    {
        e.Tipo,
        e.Modelo,
        e.Quantidade,
        Valor = e.Valor.ToString("C"),
    }).ToList();
}
    }
}



