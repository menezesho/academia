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

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {//strip >> sair
            if (MessageBox.Show("Deseja mesmo finalizar o programa?", "Sair", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                Application.Exit();
        }

        private void btlimpar_Click(object sender, EventArgs e)
        {//btlimpar
            tbusuario.Clear();
            tbsenha.Clear();
        }

        private void btsair_Click(object sender, EventArgs e)
        {//btsair
            if (MessageBox.Show("Deseja mesmo finalizar o programa?", "Sair", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                Application.Exit();
        }

        private void FormLogin_KeyDown(object sender, KeyEventArgs e)
        {//ESC para retornar
            if (e.KeyValue.Equals(27))
                if (MessageBox.Show("Deseja mesmo retornar?", "Retornar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    Application.Exit();
        }

        private void FormLogin_KeyUp(object sender, KeyEventArgs e)
        {//ENTER para salvar
            if (e.KeyValue.Equals(13))
            {
                if (cadastrar)
                {
                    Settings.Default["usuario"] = tbusuario.Text;
                    Settings.Default["senha"] = tbsenha.Text;
                    Settings.Default.Save();
                    MessageBox.Show("Cadastro efetuado com sucesso!", "Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                if (!cadastrar)
                {
                    string usuario = tbusuario.Text, senha = tbsenha.Text;

                    if (usuario == Settings.Default["usuario"].ToString())
                        if (senha == Settings.Default["senha"].ToString())
                        {
                            tbusuario.Clear();
                            tbsenha.Clear();
                            Fprincipal.ShowDialog();
                        }
                        else
                            MessageBox.Show("Senha incorreta, tente novamente!", "Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    else
                        MessageBox.Show("Usuário ou senha incorretos, tente novamente!", "Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btlogin_Click(object sender, EventArgs e)
        {//btlogin/(cadastrar)
            if (cadastrar)
            {
                Settings.Default["usuario"] = tbusuario.Text;
                Settings.Default["senha"] = tbsenha.Text;
                Settings.Default.Save();
                MessageBox.Show("Cadastro efetuado com sucesso!", "Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Information);

                /*
                string usuario, senha;
                usuario = tbusuario.Text;
                senha = tbsenha.Text;
                bool achouUsuario = false;
                if (u < 0)
                    for (int i = 0; i < u; i++)
                        if (usuario == logins[i].usuario)
                            achouUsuario = true;
                if (achouUsuario)
                    MessageBox.Show("Usuário inválido, tente novamente!", "Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                {
                    if (tbusuario.Text == "" || tbsenha.Text == "")
                        MessageBox.Show("Preencha os campos vazios!", "Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    else
                    {
                        logins[u] = new Login(tbusuario.Text, tbsenha.Text);
                        u++;
                        MessageBox.Show("Cadastro efetuado com sucesso!", "Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        tbusuario.Clear();
                        tbsenha.Clear();
                    }
                }
            */
            }
            if (!cadastrar)
            {
                string usuario = tbusuario.Text, senha = tbsenha.Text;

                if (usuario == Settings.Default["usuario"].ToString())
                    if (senha == Settings.Default["senha"].ToString())
                    {
                        tbusuario.Clear();
                        tbsenha.Clear();
                        Fprincipal.ShowDialog();
                    }
                    else
                        MessageBox.Show("Senha incorreta, tente novamente!", "Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                    MessageBox.Show("Usuário ou senha incorretos, tente novamente!", "Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {//strip >> login
            btlogin.Text = "LOGIN";
            tbusuario.Clear();
            tbsenha.Clear();
            cadastrar = false;
            MessageBox.Show("Faça seu login!", "Login", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void cadastrarToolStripMenuItem_Click(object sender, EventArgs e)
        {//strip >> cadastrar
            btlogin.Text = "CADASTRAR";
            tbusuario.Clear();
            tbsenha.Clear();
            cadastrar = true;
            MessageBox.Show("Faça já seu cadastro!", "Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void FormLogin_Load(object sender, EventArgs e)
        {
            tbusuario.Text = Settings.Default["usuario"].ToString();
            tbsenha.Text = Settings.Default["senha"].ToString();
        }
    }
}