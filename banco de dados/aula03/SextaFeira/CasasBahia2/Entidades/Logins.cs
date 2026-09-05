using System;
using System.Collections.Generic;
using System.Text;

namespace CasasBahia2.Entidades
{
    internal class Logins
    {
        //Propiedades

        public int Id { get; set; }
        public string Usuario { get; protected set; }
        public string Senha { get; protected set; }
        public string Regra { get; protected set; }
        
        //Construtor
        public Logins(string usuario, string senha, string regra)
        {
            Usuario = usuario;
            Senha = senha;
            this.Regra = regra;
        }

    }
}
