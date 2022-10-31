using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using academia.Class;
using academia.DAO;
using academia.Properties;

namespace projetofinal
{
    public partial class FormLogin : Form
    {
        Conexao conec = new Conexao();
        public FormLogin()
        {
            InitializeComponent();
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {
            ProfessorDAO professorDAO = new ProfessorDAO();
            cbUsuario.DataSource = professorDAO.listarProfs();
            cbUsuario.DisplayMember = "Usuário";
            cbUsuario.Text = "henrique-mo";
            tbSenha.Text = "321654";
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
                    this.Hide();
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