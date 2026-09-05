namespace CasasBahia2
{
    public partial class Form1 : Form
    {

        //Campo
        Form2 janela1;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string usuario = "Clodoaldo";
            string senha = "1234";

            bool login = usuario.Equals(textBox3.Text) && senha.Equals(textBox2.Text);

            if (login)
            {
                //abre a segunda tela
                janela1 = new Form2();
                Hide();
                janela1.Show();
            }
            else
            { 
              MessageBox.Show(@"Usuario/senha incorretos tente novamente!");
            }
        }
    }
}
