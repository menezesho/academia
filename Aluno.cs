using System;
using System.Collections.Generic;
using System.Text;

namespace projetofinal
{
    class Aluno : Pessoa
    {
        public float peso { get; set; }
        public float altura { get; set; }
        public int matricula { get; set; }

        public Aluno(string nome, string cpf, string endereco, string celular, string email, int idade, string aula, float peso, float altura, int matricula)
        : base(nome, cpf, endereco, celular, email, idade, aula)
        {
            this.peso = peso;
            this.altura = altura;
            this.matricula = matricula;
        }
    }
}
