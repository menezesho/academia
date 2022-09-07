using System;
using System.Collections.Generic;
using System.Text;

namespace projetofinal
{
    public class Aluno : Pessoa
    {
        public float peso { get; set; }
        public float altura { get; set; }
        public int matricula { get; set; }

        /*public Aluno(string nome, string cpf, string endereco, string celular, string email, string senha, int idade, float peso, float altura, int matricula)
        : base(nome, cpf, endereco, celular, email, senha, idade)
        {
            this.peso = peso;
            this.altura = altura;
            this.matricula = matricula;
        }*/
    }
}
