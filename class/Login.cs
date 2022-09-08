using System;
using System.Collections.Generic;
using System.Text;

namespace projetofinal
{
    class Login
    {
        public string cracha { get; set; }
        public string senha { get; set; }

        public Login(string cracha, string senha)
        {
            this.cracha = cracha;
            this.senha = senha;
        }
    }
}
