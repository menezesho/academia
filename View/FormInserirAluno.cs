﻿using academia.Class;
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
    public partial class FormInserirAluno : Form
    {
        Conexao conec = new Conexao();
        bool carregouForm = false;

        public FormInserirAluno()
        {
            InitializeComponent();
        }

        private void FormInserirNaAula_Load(object sender, EventArgs e)
        {
            AulaDAO aulaDAO = new AulaDAO();
            cbAula.Items.Clear();
            cbAula.DataSource = aulaDAO.listarAulas();
            cbAula.DisplayMember = "Nome";
            cbAula.ValueMember = "ID";

            AlunoDAO alunoDAO = new AlunoDAO();
            cbNome.DataSource = alunoDAO.listarAlunos();
            cbNome.DisplayMember = "Nome";
            cbNome.ValueMember = "ID";

            cbNome.Text = "Selecione";
            mtbCpf.Clear();
            mtbCelular.Clear();
            cbAula.Text = "Selecione";
            mtbData.Clear();
            tbHora.Clear();

            carregouForm = true;
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
        {//btInserir
            if (mtbCpf.Text == "" || tbHora.Text == "")
                MessageBox.Show("Preencha todos os campos!", "Inserir", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                try
                {
                    SqlConnection conexao = new SqlConnection(conec.ConexaoBD());
                    string sqlSelect = @"SELECT * FROM participante WHERE id_aula=@idaula AND id_aluno=@idaluno";
                    SqlCommand comandoSelect = new SqlCommand(sqlSelect, conexao);

                    comandoSelect.Parameters.AddWithValue("@idaula", int.Parse(cbAula.SelectedValue.ToString()));
                    comandoSelect.Parameters.AddWithValue("@idaluno", int.Parse(cbNome.SelectedValue.ToString()));

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
                        string sqlInsert = @"INSERT INTO participante (id_aula, id_aluno) VALUES (@idaula, @idaluno)";
                        SqlCommand comandoInsert = new SqlCommand(sqlInsert, conexao2);

                        comandoInsert.Parameters.AddWithValue("@idaula", int.Parse(cbAula.SelectedValue.ToString()));
                        comandoInsert.Parameters.AddWithValue("@idaluno", int.Parse(cbNome.SelectedValue.ToString()));

                        conexao2.Open();
                        comandoInsert.CommandText = sqlInsert;
                        comandoInsert.ExecuteNonQuery();
                        conexao2.Close();
                        MessageBox.Show("Concluído com sucesso\nO aluno '" + cbNome.Text + "' foi inserido na aula '" + cbAula.Text + "'!", "Inserir", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            if (carregouForm)
            {
                try
                {
                    SqlConnection conexao = new SqlConnection(conec.ConexaoBD());
                    string sql = @"SELECT * FROM aluno WHERE idaluno=@idaluno";
                    SqlCommand comando = new SqlCommand(sql, conexao);

                    comando.Parameters.AddWithValue("@idaluno", int.Parse(cbNome.SelectedValue.ToString()));

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
        }

        private void cbAula_SelectedIndexChanged(object sender, EventArgs e)
        {//item changed AULA
            if (carregouForm)
            {
                try
                {
                    SqlConnection conexao = new SqlConnection(conec.ConexaoBD());
                    string sql = @"SELECT * FROM aula WHERE idaula=@idaula";
                    SqlCommand comando = new SqlCommand(sql, conexao);

                    comando.Parameters.AddWithValue("@idaula", int.Parse(cbAula.SelectedValue.ToString()));

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
}
