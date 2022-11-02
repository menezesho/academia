using academia.Class;
using academia.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Security.Policy;
using System.Text;
using System.Windows.Forms;

namespace academia
{
    public partial class FormInserirNaAula : Form
    {
        Conexao conec = new Conexao();

        public FormInserirNaAula()
        {
            InitializeComponent();
        }

        private void FormInserirNaAula_Load(object sender, EventArgs e)
        {
            rbAluno.Checked = true;

            AulaDAO aulaDAO = new AulaDAO();
            cbAula.Items.Clear();
            cbAula.DataSource = aulaDAO.listarAulas();
            cbAula.DisplayMember = "Nome";
            cbAula.ValueMember = "ID";

            cbNome.Text = "Selecione";
            mtbCpf.Clear();
            mtbCelular.Clear();
            cbAula.Text = "Selecione";
            mtbData.Clear();
            tbHora.Clear();
        }

        private void rbProfessor_CheckedChanged(object sender, EventArgs e)
        {//Professor check
            ProfessorDAO professorDAO = new ProfessorDAO();
            cbNome.DataSource = professorDAO.listarProfs();
            cbNome.DisplayMember = "Nome";
            cbNome.ValueMember = "Crachá";

            cbNome.Text = "Selecione";
            mtbCpf.Clear();
            mtbCelular.Clear();
        }

        private void rbAluno_CheckedChanged(object sender, EventArgs e)
        {//Aluno check
            s
        }

        private void btLimpar_Click(object sender, EventArgs e)
        {//btLimpar
            if (MessageBox.Show("Os dados não salvos serão perdidos.\nDeseja mesmo limpar todos os campos?", "Limpar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                cbNome.Text = "Selecione";
                mtbCpf.Clear();
                mtbCelular.Clear();
                cbAula.Text = "Selecione";
                mtbData.Clear();
                tbHora.Clear();
            }
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {//btCancelar
            if (MessageBox.Show("Os dados não salvos serão perdidos!\nDeseja mesmo retornar?", "Retornar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                Close();
        }

        private void btInserir_Click(object sender, EventArgs e)
        {//brInserir
            if (mtbCpf.Text == "___________" || tbHora.Text == "")
                MessageBox.Show("Preencha os campos vazios!", "Inserir", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                try
                {
                    if (rbAluno.Checked)
                    {
                        SqlConnection conexao = new SqlConnection(conec.ConexaoBD());
                        string sqlSelect = @"SELECT * FROM participante WHERE fkaula=@idaula AND fkaluno=@idaluno";
                        SqlCommand comandoSelect = new SqlCommand(sqlSelect, conexao);

                        comandoSelect.Parameters.AddWithValue("@idaula", cbAula.SelectedValue);
                        comandoSelect.Parameters.AddWithValue("@idaluno", cbNome.SelectedValue);

                        conexao.Open();
                        SqlDataReader dados = comandoSelect.ExecuteReader();
                        if (dados.Read())
                        {
                            MessageBox.Show("Este aluno já está incluso nesta aula!", "Inserir", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            conexao.Close();
                        }
                        else
                        {
                            conexao.Close();
                            SqlConnection conexao2 = new SqlConnection(conec.ConexaoBD());
                            string sqlInsert = @"INSERT INTO participante (fkaula, fkaluno) VALUES (@idaula, @idaluno)";
                            SqlCommand comandoInsert = new SqlCommand(sqlInsert, conexao2);

                            comandoInsert.Parameters.AddWithValue("@idaula", cbAula.SelectedValue);
                            comandoInsert.Parameters.AddWithValue("@idaluno", cbNome.SelectedValue);

                            conexao2.Open();
                            comandoInsert.CommandText = sqlInsert;
                            comandoInsert.ExecuteNonQuery();
                            conexao2.Close();
                            MessageBox.Show("Concluído com sucesso\nO aluno '" + cbNome.Text + "' foi inserido na aula '" + cbAula.Text + "'!", "Inserir", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    else
                    {
                        SqlConnection conexao = new SqlConnection(conec.ConexaoBD());
                        string sqlSelect = @"SELECT * FROM participante WHERE fkaula=@idaula AND fkprof=@idprof";
                        SqlCommand comandoSelect = new SqlCommand(sqlSelect, conexao);

                        comandoSelect.Parameters.AddWithValue("@idaula", cbAula.SelectedValue);
                        comandoSelect.Parameters.AddWithValue("@idprof", cbNome.SelectedValue);

                        conexao.Open();
                        SqlDataReader dados = comandoSelect.ExecuteReader();
                        if (dados.Read())
                        {
                            MessageBox.Show("Este professor já está ministrando esta aula!", "Inserir", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            conexao.Close();
                        }
                        else
                        {
                            conexao.Close();
                            SqlConnection conexao2 = new SqlConnection(conec.ConexaoBD());
                            string sqlInsert = @"INSERT INTO participante (fkaula, fkprof) VALUES (@idaula, @idprof)";
                            SqlCommand comandoInsert = new SqlCommand(sqlInsert, conexao2);

                            comandoInsert.Parameters.AddWithValue("@idaula", cbAula.SelectedValue);
                            comandoInsert.Parameters.AddWithValue("@idprof", cbNome.SelectedValue);

                            conexao2.Open();
                            comandoInsert.CommandText = sqlInsert;
                            comandoInsert.ExecuteNonQuery();
                            conexao2.Close();
                            MessageBox.Show("Concluído com sucesso\nO professor '" + cbNome.Text + "' foi inserido na aula '" + cbAula.Text + "'!", "Inserir", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
                catch (Exception erro)
                {
                    MessageBox.Show(erro.Message, "Erro na conexão, tente novamente!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        private void cbNome_SelectedIndexChanged(object sender, EventArgs e)
        {//item changed NOME
            try
            {
                SqlConnection conexao = new SqlConnection(conec.ConexaoBD());
                string sql = "";
                if (rbAluno.Checked)
                    sql = @"SELECT * FROM aluno WHERE matricula=@id";
                else
                    sql = @"SELECT * FROM professor WHERE cracha=@id";
                SqlCommand comando = new SqlCommand(sql, conexao);

                comando.Parameters.AddWithValue("@id", cbNome.SelectedValue);

                conexao.Open();
                comando.CommandText = sql;
                comando.ExecuteNonQuery();
                SqlDataReader dados = comando.ExecuteReader();
                if (dados.Read())
                {
                    mtbCpf.Text = dados["cpf"].ToString();
                    mtbCelular.Text = dados["celular"].ToString();
                }
                conexao.Close();
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message, "Erro na conexão, tente novamente!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cbAula_SelectedIndexChanged(object sender, EventArgs e)
        {//item changed AULA
            try
            {
                SqlConnection conexao = new SqlConnection(conec.ConexaoBD());
                string sql = @"SELECT * FROM aula WHERE id=@id";
                SqlCommand comando = new SqlCommand(sql, conexao);

                comando.Parameters.AddWithValue("@id", cbAula.SelectedValue);

                conexao.Open();
                comando.CommandText = sql;
                comando.ExecuteNonQuery();
                SqlDataReader dados = comando.ExecuteReader();
                if (dados.Read())
                {
                    mtbData.Text = dados["dia"].ToString();
                    tbHora.Text = dados["hora"].ToString();
                }
                conexao.Close();
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message, "Erro na conexão, tente novamente!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }
    }
}
