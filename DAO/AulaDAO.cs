using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Text;
using System.Text.RegularExpressions;

namespace academia.DAO
{
    public class AulaDAO
    {
        public DataTable listarAulas()
        {
            string strConexao = @"Data Source=lenovo-l340\sqlexpress;Initial Catalog=BD_ACADEMIA;Integrated Security=True";
            SqlConnection conexao = new SqlConnection(strConexao);
            string sql = @"SELECT id AS ID, nome AS Nome, dia AS Data, hora AS Horário FROM aula";
            SqlCommand comando = new SqlCommand(sql, conexao);
            conexao.Open();
            comando.ExecuteNonQuery();
            DataTable tabelaAulas = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(comando);
            da.Fill(tabelaAulas);
            conexao.Close();
            return tabelaAulas;
        }
    }
}
