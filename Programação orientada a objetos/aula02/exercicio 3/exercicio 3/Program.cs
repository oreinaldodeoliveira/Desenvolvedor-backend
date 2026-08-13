namespace Exercicio03
{
    internal class Exertres
    {
        //Campos
        public string nome;
        public double nota1, nota2, nota3, notafinal;

        //Constructor
        public Exertres(string nome, double nota1, double nota2, double nota3)
        {
            this.nome = nome;
            this.nota1 = nota1;
            this.nota2 = nota2;
            this.nota3 = nota3;

            notafinal = nota1 + nota2 + nota3;
        }
    }
}        