using Cars.Classes.Animation;
using Cars.Classes.Contextos;
using Microsoft.IdentityModel.Tokens;

namespace Cars;

public partial class Principal : Form
{
    // Controlador que concentra toda a lógica de animação do panel1.
    private readonly AnimationPanel animacaoPainel;

    public Principal()
    {
        // Inicializa os controles criados pelo Windows Forms Designer.
        InitializeComponent();

        // Cria o controlador e informa qual painel deverá ser animado.
        animacaoPainel = new AnimationPanel(panel1);

        // Associa os botões de navegação ao método que fecha o painel.
        button3.Click += FecharPanel_Click;
        button4.Click += FecharPanel_Click;
        button5.Click += FecharPanel_Click;
    }

    private void button2_Click(object? sender, EventArgs e)
    {
        // Solicita à classe de animação que abra o painel ao clicar em Comprar.
        animacaoPainel.Abrir();
    }

    private void FecharPanel_Click(object? sender, EventArgs e)
    {
        // Solicita à classe de animação que feche o painel.
        animacaoPainel.Fechar();
    }

    private void button1_Click(object sender, EventArgs e)
    {

        EstoqueContexto contexto = new EstoqueContexto();

        bool moto = radioButton1.Checked;
        bool carro = radioButton2.Checked;
        string texto = textBox1.Text;

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





