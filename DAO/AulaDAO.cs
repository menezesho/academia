﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Text;
using System.Text.RegularExpressions;
using academia.Class;

namespace academia.DAO
{
    public class AulaDAO
    {
        Conexao conec = new Conexao();

        public DataTable listarAulas()
        {
            SqlConnection conexao = new SqlConnection(conec.ConexaoBD());
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
