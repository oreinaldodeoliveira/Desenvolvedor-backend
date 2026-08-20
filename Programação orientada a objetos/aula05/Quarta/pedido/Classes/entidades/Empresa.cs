
using System.ComponentModel.DataAnnotations.Schema;

namespace pedido.Classes.entidades
{
    internal class Empresa
    {
        //1° - campos
        private string nome;
		private List<Funcionario> Funcionarios;


        //2° - propriedades
        public List<Funcionario> ListaDeFuncionarios    
        {
            get { return Funcionarios; }
            set { Funcionarios = value; }
        }


        public string NomeDaempresa 
		{
			get { return nome; }
			set { nome  = value; }
		}

        //Construtor
        public Empresa(string NomeDaEmpresa)
        {
            NomeDaEmpresa = NomeDaempresa;
           ListaDeFuncionarios = new List<Funcionario>();
        }

        //4° - métodos

        public void AdicionarFuncionario(Funcionario funcionario)
        {
            ListaDeFuncionarios.Add(funcionario);
        }




























    }
}
