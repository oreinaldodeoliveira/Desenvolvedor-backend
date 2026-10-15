using Cars.Classes.Animation;
using Cars.Classes.Contextos;
using Cars.Classes.Services;
using Cars.Classes.serviços;
using Microsoft.IdentityModel.Tokens;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace Cars;

public partial class Principal : Form
{
    // Controlador que concentra toda a lógica de animação do painel.
    private readonly AnimationPanel animacaoPainel;
    EstoqueContexto contexto = new EstoqueContexto();

    public Principal()
    {
        // Inicializa os controles criados pelo Windows Forms Designer.
        InitializeComponent();

        // Cria o controlador e informa qual painel deverá ser animado.
        animacaoPainel = new AnimationPanel(panel1);

        // Associa os botões de navegação ao método que fecha o painel.
        button3.Click += FecharPainel_Click;
        button4.Click += FecharPainel_Click;
        button5.Click += FecharPainel_Click;
    }

    // Botão de comprar
    private void button2_Click(object? sender, EventArgs e)
    {
        DataGridViewRow linhaselcionada = dataGridView1.SelectedRows[0];

        textBox2.Text = linhaselcionada.Cells["Modelo"].Value.ToString();
        textBox3.Text = linhaselcionada.Cells["Tipo"].Value.ToString();
        textBox4.Text = linhaselcionada.Cells["Valor"].Value.ToString();
        textBox5.Text = linhaselcionada.Cells["Quantidade"].Value.ToString();

        string texto = linhaselcionada.Cells["Foto"].Value.ToString();
        MessageBox.Show(texto);

        // Solicita à classe de animação que abra o painel ao clicar em Comprar.
        animacaoPainel.Abrir();
    }

    private void FecharPainel_Click(object? sender, EventArgs e)
    {
        // Solicita à classe de animação que feche o painel.
        animacaoPainel.Fechar();
    }

    private void button1_Click(object sender, EventArgs e)
    {
        bool moto = checkBox1.Checked;
        bool carro = checkBox2.Checked;
        string texto = textBox1.Text;

        Pesquisa.Pesquisas(moto, carro, texto, dataGridView1);
    }

    private void Principal_BindingContextChanged(object sender, EventArgs e)
    {
    }

    private void checkBox1_CheckedChanged(object sender, EventArgs e)
    {
    }
}