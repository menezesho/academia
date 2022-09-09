using System;
using System.Collections.Generic;
using System.Text;

namespace projetofinal
{
    public class Professor : Pessoa
    {
        public int cracha { get; set; }
        public string senha { get; set; }


        /*public Professor(string nome, string cpf, string endereco, string celular, string email, string senha, int idade, int cracha)
        : base(nome, cpf, endereco, celular, email, senha, idade)
        {
            this.cracha = cracha;
        }*/
    }
}
