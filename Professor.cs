using System;
using System.Collections.Generic;
using System.Text;
/*
 classe professor que herda s métodos da classe pessoa e tambem faz cadastro
porem de professor e possui entrada amais para o cadastro do chachá
 */
namespace projetofinal
{
    class Professor : Pessoa
    {
        public int cracha { get; set; }

        public Professor(string nome, string cpf, string endereco, string celular, string email, int idade, string aula, int cracha)
        : base(nome, cpf, endereco, celular, email, idade, aula)
        {
            this.cracha = cracha;
        }
    }
}
