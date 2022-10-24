using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using academia;
using academia.Properties;

namespace projetofinal
{
    public partial class FormLogin : Form
    {
        ConexaoDAO conec = new ConexaoDAO();
        public FormLogin()
        {
            InitializeComponent();
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {
            Funcoes funcoes = new Funcoes();
            cbUsuario.DataSource = funcoes.listarProfs();
            cbUsuario.DisplayMember = "Usuário";
            cbUsuario.Text = "";
        }

        private void btLogin_Click(object sender, EventArgs e)
        {//btLogin
            try
            {
                SqlConnection conexao = new SqlConnection(conec.ConexaoBD());
                string sql = @"SELECT * FROM professor WHERE usuario=@usuario AND senha=@senha";
                SqlCommand comando = new SqlCommand(sql, conexao);

                comando.Parameters.AddWithValue("@usuario", cbUsuario.Text);
                comando.Parameters.AddWithValue("@senha", tbSenha.Text);

                conexao.Open();
                SqlDataReader dados = comando.ExecuteReader();
                if (dados.Read())
                {
                    FormPrincipal Fp = new FormPrincipal();
                    cbUsuario.Text = "";
                    tbSenha.Clear();
                    Fp.Show();
                }
                else
                    MessageBox.Show("Usuário ou senha incorretos, tente novamente!", "Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
                conexao.Close();
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message, "Erro na conexão, tente novamente!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btLimpar_Click(object sender, EventArgs e)
        {//btLimpar
            cbUsuario.Text = "";
            tbSenha.Clear();
        }

        private void lbReload_Click(object sender, EventArgs e)
        {//lbReload
            Funcoes funcoes = new Funcoes();
            cbUsuario.DataSource = funcoes.listarProfs();
            cbUsuario.DisplayMember = "Usuário";
            cbUsuario.Text = "";
            tbSenha.Clear();
        }

        private void lbVerSenha_Click(object sender, EventArgs e)
        {//lbVerSenha
            if (tbSenha.UseSystemPasswordChar.Equals(false))
                tbSenha.UseSystemPasswordChar = true;
            else
                tbSenha.UseSystemPasswordChar = false;
        }

        #region Sair

        private void FormLogin_KeyDown(object sender, KeyEventArgs e)
        {//ESC para retornar
            if (e.KeyValue.Equals(27))
                Application.Exit();
        }

        private void lbSair_Click(object sender, EventArgs e)
        {//lbSair
            Application.Exit();
        }

        #endregion

    }
}