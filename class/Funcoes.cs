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
        #region Aluno
        public void cadastrarAluno(Aluno alunos)
        {
            try
            {
                string strConexao = @"Data Source=Lenovo-L340\sqlexpress;Initial Catalog=BD_ACADEMIA;Integrated Security=True";
                SqlConnection conexao = new SqlConnection(strConexao);
                string sql = @"INSERT INTO aluno (matricula, nome, cpf, idade, endereco, celular, email, peso, altura) VALUES (@matricula, @nome, @cpf, @idade, @endereco, @celular, @email, @peso, @altura)";
                SqlCommand comando = new SqlCommand(sql, conexao);

                comando.Parameters.AddWithValue("@matricula", alunos.matricula);
                comando.Parameters.AddWithValue("@nome", alunos.nome);
                comando.Parameters.AddWithValue("@cpf", alunos.cpf);
                comando.Parameters.AddWithValue("@idade", alunos.idade.ToString());
                comando.Parameters.AddWithValue("@endereco", alunos.endereco);
                comando.Parameters.AddWithValue("@celular", alunos.celular);
                comando.Parameters.AddWithValue("@email", alunos.email);
                comando.Parameters.AddWithValue("@peso", alunos.peso.ToString());
                comando.Parameters.AddWithValue("@altura", alunos.altura.ToString());

                conexao.Open();
                comando.CommandText = sql;
                comando.ExecuteNonQuery();
                conexao.Close();
                MessageBox.Show("Cadastro efetuado com sucesso!", "Cadastrar", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message, "Erro na conexão, tente novamente!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void editarAluno(Aluno alunos)
        {
            try
            {
                string strConexao = @"Data Source=Lenovo-L340\sqlexpress;Initial Catalog=BD_ACADEMIA;Integrated Security=True";
                SqlConnection conexao = new SqlConnection(strConexao);
                string sql = @"UPDATE aluno SET nome=@nome, cpf=@cpf, idade=@idade, endereco=@endereco, celular=@celular, email=@email, peso=@peso, altura=@altura WHERE matricula=@matricula";
                SqlCommand comando = new SqlCommand(sql, conexao);

                comando.Parameters.AddWithValue("@nome", alunos.nome);
                comando.Parameters.AddWithValue("@cpf", alunos.cpf.ToString());
                comando.Parameters.AddWithValue("@idade", alunos.idade.ToString());
                comando.Parameters.AddWithValue("@endereco", alunos.endereco);
                comando.Parameters.AddWithValue("@celular", alunos.celular);
                comando.Parameters.AddWithValue("@email", alunos.email);
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
        }

        public DataTable listarAlunos()
        {
            string strConexao = @"Data Source=Lenovo-L340\sqlexpress;Initial Catalog=BD_ACADEMIA;Integrated Security=True";
            SqlConnection conexao = new SqlConnection(strConexao);
            string sql = @"SELECT matricula AS Matrícula, nome AS Nome, cpf AS CPF, idade AS Idade, endereco AS Endereço, celular AS Celular, email AS 'E-mail', peso AS 'Peso(kg)', altura AS 'Altura(cm)' FROM aluno";
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

                MessageBox.Show("Cadastro excluido com sucesso!", "Excluir", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message, "Erro na conexão, tente novamente!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion

        #region Professor

        public void cadastrarProf(Professor profs)
        {
            try
            {
                string strConexao = @"Data Source=Lenovo-L340\sqlexpress;Initial Catalog=BD_ACADEMIA;Integrated Security=True";
                SqlConnection conexao = new SqlConnection(strConexao);
                string sql = @"INSERT INTO professor (cracha, nome, cpf, idade, endereco, celular, email, usuario, senha) VALUES (@matricula, @nome, @cpf, @idade, @endereco, @celular, @email, @usuario, @senha)";
                SqlCommand comando = new SqlCommand(sql, conexao);

                comando.Parameters.AddWithValue("@matricula", profs.cracha);
                comando.Parameters.AddWithValue("@nome", profs.nome);
                comando.Parameters.AddWithValue("@cpf", profs.cpf);
                comando.Parameters.AddWithValue("@idade", profs.idade.ToString());
                comando.Parameters.AddWithValue("@endereco", profs.endereco);
                comando.Parameters.AddWithValue("@celular", profs.celular);
                comando.Parameters.AddWithValue("@email", profs.email);
                comando.Parameters.AddWithValue("@usuario", profs.usuario);
                comando.Parameters.AddWithValue("@senha", profs.senha);

                conexao.Open();
                comando.CommandText = sql;
                comando.ExecuteNonQuery();
                conexao.Close();
                MessageBox.Show("Cadastro efetuado com sucesso!", "Cadastrar", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message, "Erro na conexão, tente novamente!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void editarProf(Professor profs)
        {
            try
            {
                string strConexao = @"Data Source=Lenovo-L340\sqlexpress;Initial Catalog=BD_ACADEMIA;Integrated Security=True";
                SqlConnection conexao = new SqlConnection(strConexao);
                string sql = @"UPDATE professor SET nome=@nome, cpf=@cpf, idade=@idade, endereco=@endereco, celular=@celular, email=@email, usuario=@usuario, senha=@senha WHERE cracha = @cracha";
                SqlCommand comando = new SqlCommand(sql, conexao);

                comando.Parameters.AddWithValue("@nome", profs.nome);
                comando.Parameters.AddWithValue("@cpf", profs.cpf.ToString());
                comando.Parameters.AddWithValue("@idade", profs.idade.ToString());
                comando.Parameters.AddWithValue("@endereco", profs.endereco);
                comando.Parameters.AddWithValue("@celular", profs.celular);
                comando.Parameters.AddWithValue("@email", profs.email);
                comando.Parameters.AddWithValue("@usuario", profs.usuario);
                comando.Parameters.AddWithValue("@senha", profs.senha);
                comando.Parameters.AddWithValue("@cracha", profs.cracha);

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
        }

        public DataTable listarProfs()
        {
            string strConexao = @"Data Source=Lenovo-L340\sqlexpress;Initial Catalog=BD_ACADEMIA;Integrated Security=True";
            SqlConnection conexao = new SqlConnection(strConexao);
            string sql = @"SELECT cracha AS Crachá, nome AS Nome, cpf AS CPF, idade AS Idade, endereco AS Endereço, celular AS Celular, email AS 'E-mail', usuario AS Usuário, senha AS Senha FROM professor";
            SqlCommand comando = new SqlCommand(sql, conexao);
            conexao.Open();
            comando.ExecuteNonQuery();
            DataTable tabelaProfs = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(comando);
            da.Fill(tabelaProfs);
            conexao.Close();
            return tabelaProfs;
        }

        public void excluirProf(Professor profs)
        {
            try
            {
                string strConexao = @"Data Source=Lenovo-L340\sqlexpress;Initial Catalog=BD_ACADEMIA;Integrated Security=True";
                SqlConnection conexao = new SqlConnection(strConexao);
                string sql = @"DELETE FROM professor WHERE cracha = @cracha";
                SqlCommand comando = new SqlCommand(sql, conexao);

                comando.Parameters.AddWithValue("@cracha", profs.cracha);

                conexao.Open();
                comando.CommandText = sql;
                comando.ExecuteNonQuery();
                conexao.Close();

                MessageBox.Show("Cadastro excluido com sucesso!", "Excluir", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message, "Erro na conexão, tente novamente!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion

        #region Login

        public void loginProf(string usuario, string senha)
        {
            try
            {
                string strConexao = @"Data Source=Lenovo-L340\sqlexpress;Initial Catalog=BD_ACADEMIA;Integrated Security=True";
                SqlConnection conexao = new SqlConnection(strConexao);
                string sql = @"SELECT * FROM professor WHERE usuario=@usuario AND senha=@senha";
                SqlCommand comando = new SqlCommand(sql, conexao);

                comando.Parameters.AddWithValue("@usuario", usuario);
                comando.Parameters.AddWithValue("@senha", senha);

                conexao.Open();
                SqlDataReader dados = comando.ExecuteReader();
                if (dados.Read())
                {
                    FormPrincipal Fp = new FormPrincipal();
                    Fp.ShowDialog();
                    conexao.Close();
                }
                else
                {
                    MessageBox.Show("Usuário ou senha incorretos, tente novamente!", "Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    conexao.Close();
                }
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message, "Erro na conexão, tente novamente!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion
    }
}
