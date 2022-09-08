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
        public FormLogin()
        {
            InitializeComponent();
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {//load
            Funcoes funcoes = new Funcoes();
            cbnome.DataSource = funcoes.listarProfs();
            cbnome.DisplayMember = "nome";
            cbnome.Text = "";
        }

        private void btversenha_Click(object sender, EventArgs e)
        {//btversenha
            if (tbsenha.UseSystemPasswordChar.Equals(false))
                tbsenha.UseSystemPasswordChar = true;
            else
                tbsenha.UseSystemPasswordChar = false;
        }

        private void btlogin_Click(object sender, EventArgs e)
        {//btlogin
            string nome, senha;

            nome = cbnome.Text;
            senha = tbsenha.Text;
            Funcoes funcoes = new Funcoes();
            funcoes.loginProf(nome, senha);
        }

        private void btlimpar_Click(object sender, EventArgs e)
        {//btlimpar
            cbnome.Text = "";
            tbsenha.Clear();
        }

        private void btsair_Click(object sender, EventArgs e)
        {//btsair
            if (MessageBox.Show("Deseja mesmo finalizar o programa?", "Sair", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                Application.Exit();
        }

        private void btreload_Click(object sender, EventArgs e)
        {//btreload
            Funcoes funcoes = new Funcoes();
            cbnome.DataSource = funcoes.listarProfs();
            cbnome.DisplayMember = "nome";
            cbnome.Text = "";
            tbsenha.Clear();
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
    }
}