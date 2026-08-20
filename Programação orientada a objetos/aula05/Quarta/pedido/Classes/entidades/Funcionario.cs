namespace pedido.Classes.entidades
{
    //Objeto que pode existir de forma independente
    internal class Funcionario
    {
        //1° - campos
        private string _nome;

        //2° - propriedades
        protected string nome;

        public Funcionario
        {  
            get { return this; }
            set { nome = value; }
        }

        //3° - construtor
        public Funcionario(string nome)
        {
            _nome = nome;
        }

    }
}
