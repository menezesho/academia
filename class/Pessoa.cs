using System;
using System.Collections.Generic;
using System.Text;

namespace projetofinal
{
    public class Pessoa
    {
        public string nome { get; set; }
        public string cpf { get; set; }
        public int idade { get; set; }
        public string endereco { get; set; }
        public string celular { get; set; }
        public string email { get; set; }

        /*public Pessoa(string nome, string cpf, string endereco, string celular, string email, string senha, int idade)
        {
            this.nome = nome;
            this.cpf = cpf;
            this.celular = celular;
            this.email = email;
            this.endereco = endereco;
            this.senha = senha;
            this.idade = idade;
        }*/
    }
}
