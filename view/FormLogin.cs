using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using projetofinal.Properties;

namespace projetofinal
{
    public partial class FormLogin : Form
    {
        FormPrincipal Fprincipal = new FormPrincipal();

        //int u = 0;
        bool cadastrar = false;

        public FormLogin()
        {
            InitializeComponent();
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {
            tbcracha.Text = Settings.Default["usuario"].ToString();
            tbsenha.Text = Settings.Default["senha"].ToString();
        }

        private void FormLogin_KeyUp(object sender, KeyEventArgs e)
        {//ENTER para logar
            if (e.KeyValue.Equals(13))
            {
                string cracha, senha;

                cracha = tbcracha.Text;
                senha = tbsenha.Text;
                Funcoes funcoes = new Funcoes();
                funcoes.loginProf(cracha, senha);
                tbcracha.Clear();
                tbsenha.Clear();
            }
        }

        private void btlogin_Click(object sender, EventArgs e)
        {//btlogin
            string cracha, senha;

            cracha = tbcracha.Text;
            senha = tbsenha.Text;
            Funcoes funcoes = new Funcoes();
            funcoes.loginProf(cracha, senha);
        }

        private void btlimpar_Click(object sender, EventArgs e)
        {//btlimpar
            tbcracha.Clear();
            tbsenha.Clear();
        }

        private void btsair_Click(object sender, EventArgs e)
        {//btsair
            if (MessageBox.Show("Deseja mesmo finalizar o programa?", "Sair", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                Application.Exit();
        }

        #region Sair

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {//strip >> sair
            if (MessageBox.Show("Deseja mesmo finalizar o programa?", "Sair", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                Application.Exit();
        }

        private void FormLogin_KeyDown(object sender, KeyEventArgs e)
        {//ESC para retornar
            if (e.KeyValue.Equals(27))
                if (MessageBox.Show("Deseja mesmo retornar?", "Retornar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    Application.Exit();
        }

        #endregion

        private void btversenha_Click(object sender, EventArgs e)
        {//btversenha
            if (tbsenha.UseSystemPasswordChar.Equals(false))
                tbsenha.UseSystemPasswordChar = true;
            else
                tbsenha.UseSystemPasswordChar = false;
        }
    }
}