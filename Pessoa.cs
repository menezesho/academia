using System;
using System.Collections.Generic;
using System.Text;
/*
 classe pessoa que possui os métodos de entrada de dados e é usada
para fazer o cadastro de pessoas/alunos
 */
namespace projetofinal
{
    class Pessoa
    {
        public string nome { get; set; }
        public string cpf { get; set; }
        public int idade { get; set; }
        public string endereco { get; set; }
        public string celular { get; set; }
        public string email { get; set; }
        public string aula { get; set; }

        public Pessoa(string nome, string cpf, string endereco, string celular, string email, int idade, string aula)
        {
            this.nome = nome;
            this.cpf = cpf;
            this.celular = celular;
            this.email = email;
            this.endereco = endereco;
            this.idade = idade;
            this.aula = aula;
        }
    }
}
