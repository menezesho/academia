using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace projetofinal
{
    public partial class FormCadProf : Form
    {
        public FormCadProf()
        {
            InitializeComponent();
        }

        private void FormCadProf_Load(object sender, EventArgs e)
        {
            tbNome.Clear();
            tbNome.Enabled = true;
            mtbCpf.Clear();
            mtbCpf.Enabled = true;
            tbIdade.Clear();
            tbIdade.Enabled = true;
            tbEndereco.Clear();
            tbEndereco.Enabled = true;
            mtbCelular.Clear();
            mtbCelular.Enabled = true;
            tbEmail.Clear();
            tbEmail.Enabled = true;
            tbUsuario.Clear();
            tbUsuario.Enabled = true;
            tbSenha.Clear();
            tbSenha.Enabled = true;
        }

        private void btLimpar_Click(object sender, EventArgs e)
        {//btLimpar
            tbNome.Enabled = true;
            mtbCpf.Enabled = true;
            tbIdade.Enabled = true;
            tbEndereco.Enabled = true;
            mtbCelular.Enabled = true;
            tbEmail.Enabled = true;
            tbUsuario.Clear();
            tbSenha.Enabled = true;
            btCadastrar.Enabled = true;
            tbNome.Clear();
            mtbCpf.Clear();
            tbIdade.Clear();
            tbEndereco.Clear();
            mtbCelular.Clear();
            tbEmail.Clear();
            tbSenha.Clear();
            MessageBox.Show("Todos os campos foram limpos!", "Limpar", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btCadastrar_Click(object sender, EventArgs e)
        {//btCadastrar
            if (tbNome.Text == "" || mtbCpf.Text == "___________" || tbIdade.Text == "" || tbEndereco.Text == "" || mtbCelular.Text == "___________" || tbSenha.Text == "" || tbUsuario.Text == "" || tbSenha.Text == "")
                MessageBox.Show("Preencha os campos vazios!", "Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                var cpfVerificado = Funcoes.verificarCpf(mtbCpf.Text);
                var celularVerificado = Funcoes.verificarCelular(mtbCelular.Text);
                if (cpfVerificado)
                {
                    if (celularVerificado)
                    {
                        Professor profs = new Professor();

                        profs.nome = tbNome.Text;
                        profs.cpf = mtbCpf.Text;
                        profs.idade = int.Parse(tbIdade.Text);
                        profs.endereco = tbEndereco.Text;
                        profs.celular = mtbCelular.Text;
                        profs.email = tbEmail.Text;
                        profs.usuario = tbUsuario.Text;
                        profs.senha = tbSenha.Text;

                        string cpf = mtbCpf.Text;
                        Funcoes funcoes = new Funcoes();
                        funcoes.verificarCpfProfessor(cpf, profs);
                    }
                    else
                        MessageBox.Show("Insira o número de celular corretamente!", "Cadastrar", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }

                else
                    MessageBox.Show("Insira o CPF corretamente!", "Cadastrar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        #region Retornar

        private void FormCadProf_KeyDown(object sender, KeyEventArgs e)
        {//ESC para retornar
            if (e.KeyValue.Equals(27))
                if (MessageBox.Show("Deseja mesmo retornar?", "Retornar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    Close();
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {//btCancelar
            if (MessageBox.Show("Os dados não salvos serão perdidos!\nDeseja mesmo retornar?", "Retornar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                Close();
        }

        #endregion

    }
}
