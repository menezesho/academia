using System;
using System.Collections.Generic;
using System.Text;

namespace academia
{
    public class ConexaoDAO
    {
        public string ConexaoBD()
        {
            string strConexao = @"Data Source=Lenovo-L340\sqlexpress;Initial Catalog=BD_ACADEMIA;Integrated Security=True";
            return strConexao;
        }
    }
}
