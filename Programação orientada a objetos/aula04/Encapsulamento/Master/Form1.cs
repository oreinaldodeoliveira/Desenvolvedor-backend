using Banco

namespace Master
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //Declaração de variáveis
        string nome;
        int numero;
        double saldo;
        ContaBancaria conta;
        

        private void label1_Click(object sender, EventArgs e)
        {
            nome = textBox1.Text;
            numero = int.Parse(textBox2.Text);
            saldo = double.Parse(textBox3.Text);

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
