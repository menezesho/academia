using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;


namespace projetofinal
{
    public class Funcoes
    {
        public void cadastrarAluno(Aluno obj)
        {
            SqlConnection conexao = new SqlConnection();
            string sql = @"INSERT INTO aluno (nome, cpf, idade, endereco, celular, email, peso, altura) VALUES (matricula=@matricula, nome=@nome, cpf=@cpf, idade=@idade, endereco=@endereco, celular=@celular, email=@email, peso=@peso, altura=@altura)";
            SqlCommand comando = new SqlCommand(sql, conexao);
            conexao.Open();
            //comando.Parameters.AddWithValue("@matricula", alunos.matricula);
            comando.Parameters.AddWithValue("@nome", obj.nome);
            comando.Parameters.AddWithValue("@cpf", obj.cpf.ToString());
            comando.Parameters.AddWithValue("@idade", obj.idade.ToString());
            comando.Parameters.AddWithValue("@endereco", obj.endereco);
            comando.Parameters.AddWithValue("@celular", obj.celular);
            comando.Parameters.AddWithValue("@email", obj.email);
            comando.Parameters.AddWithValue("@peso", obj.peso.ToString());
            comando.Parameters.AddWithValue("@altura", obj.altura.ToString());

            comando.ExecuteNonQuery();
            conexao.Close();
            MessageBox.Show("Cadastro efetuado com sucesso!", "Cadastrar", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        public void editarAluno(Aluno alunos)
        {
            try
            {
                string strConexao = @"Data Source=Lenovo-L340\sqlexpress;Initial Catalog=BD_ACADEMIA;Integrated Security=True";
                SqlConnection conexao = new SqlConnection(strConexao);
                string sql = @"UPDATE aluno SET nome=@nome, cpf=@cpf, idade=@idade, endereco=@endereco, celular=@celular, email=@email, senha=@senha, peso=@peso, altura=@altura WHERE matricula = @matricula";
                SqlCommand comando = new SqlCommand(sql, conexao);
                
                comando.Parameters.AddWithValue("@nome", alunos.nome);
                comando.Parameters.AddWithValue("@cpf", alunos.cpf.ToString());
                comando.Parameters.AddWithValue("@idade", alunos.idade.ToString());
                comando.Parameters.AddWithValue("@endereco", alunos.endereco);
                comando.Parameters.AddWithValue("@celular", alunos.celular);
                comando.Parameters.AddWithValue("@email", alunos.email);
                comando.Parameters.AddWithValue("@senha", alunos.senha);
                comando.Parameters.AddWithValue("@peso", alunos.peso.ToString());
                comando.Parameters.AddWithValue("@altura", alunos.altura.ToString());
                comando.Parameters.AddWithValue("@matricula", alunos.matricula);

                conexao.Open();
                comando.CommandText = sql;
                comando.ExecuteNonQuery();
                conexao.Close();

                MessageBox.Show("Cadastro alterado com sucesso!", "Editar", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message, "Erro na conexão, tente novamente!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
            }
        }

        public DataTable listarAlunos()
        {
            string strConexao = @"Data Source=Lenovo-L340\sqlexpress;Initial Catalog=BD_ACADEMIA;Integrated Security=True";
            SqlConnection conexao = new SqlConnection(strConexao);
            string sql = @"SELECT * FROM aluno";
            SqlCommand comando = new SqlCommand(sql, conexao);
            conexao.Open();
            comando.ExecuteNonQuery();
            DataTable tabelaAlunos = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(comando);
            da.Fill(tabelaAlunos);
            conexao.Close();
            return tabelaAlunos;
        }

        public void excluirAluno(Aluno alunos)
        {
            try
            {
                string strConexao = @"Data Source=Lenovo-L340\sqlexpress;Initial Catalog=BD_ACADEMIA;Integrated Security=True";
                SqlConnection conexao = new SqlConnection(strConexao);
                string sql = @"DELETE FROM aluno WHERE matricula = @matricula";
                SqlCommand comando = new SqlCommand(sql, conexao);

                comando.Parameters.AddWithValue("@matricula", alunos.matricula);

                conexao.Open();
                comando.CommandText = sql;
                comando.ExecuteNonQuery();
                conexao.Close();

                MessageBox.Show("Aluno excluido com sucesso!", "Excluir", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message, "Erro na conexão, tente novamente!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
            }
        }
    }
}
