using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Text;
using System.Security.Policy;
using academia.Class;

namespace academia.DAO
{
    public class ProfessorDAO
    {
        Conexao conec = new Conexao();

        public DataTable listarProfs()
        {
            SqlConnection conexao = new SqlConnection(conec.ConexaoBD());
            string sql = @"SELECT idprofessor AS 'ID', nome AS Nome, cpf AS CPF, idade AS Idade, celular AS Celular, email AS 'E-mail', senha AS Senha, rua AS Rua, numero AS 'Num.', apto AS 'Apto.', bairro AS Bairro, cidade AS Cidade, estado AS Estado FROM professor";
            SqlCommand comando = new SqlCommand(sql, conexao);
            conexao.Open();
            comando.ExecuteNonQuery();
            DataTable tabelaProfs = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(comando);
            da.Fill(tabelaProfs);
            conexao.Close();
            return tabelaProfs;
        }
    }
}
