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

        private void Form3_Load(object sender, EventArgs e)
        {//load
            tbnome.Clear();
            tbnome.Enabled = true;
            mtbcpf.Clear();
            mtbcpf.Enabled = true;
            tbidade.Clear();
            tbidade.Enabled = true;
            tbendereco.Clear();
            tbendereco.Enabled = true;
            mtbcelular.Clear();
            mtbcelular.Enabled = true;
            tbemail.Clear();
            tbemail.Enabled = true;
            tbusuario.Clear();
            tbusuario.Enabled = true;
            tbsenha.Clear();
            tbsenha.Enabled = true;
            tabControl1.SelectedTab = tabPage1;
        }

        private void btlimpar_Click_1(object sender, EventArgs e)
        {//btlimpar
            tbnome.Enabled = true;
            mtbcpf.Enabled = true;
            tbidade.Enabled = true;
            tbendereco.Enabled = true;
            mtbcelular.Enabled = true;
            tbemail.Enabled = true;
            tbusuario.Clear();
            tbsenha.Enabled = true;
            btsalvar.Enabled = true;
            tbnome.Clear();
            mtbcpf.Clear();
            tbidade.Clear();
            tbendereco.Clear();
            mtbcelular.Clear();
            tbemail.Clear();
            tbsenha.Clear();
            MessageBox.Show("Todos os campos foram limpos!", "Limpar", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btsalvar_Click(object sender, EventArgs e)
        {//btsalvar
            if (tbnome.Text == "" || mtbcpf.Text == "   .   .   -" || tbidade.Text == "" || tbendereco.Text == "" || mtbcelular.Text == "(  )      -" || tbsenha.Text == "" || tbusuario.Text == "" || tbsenha.Text == "")
                MessageBox.Show("Preencha os campos vazios!", "Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                Professor profs = new Professor();

                profs.nome = tbnome.Text;
                profs.cpf = mtbcpf.Text;
                profs.idade = int.Parse(tbidade.Text);
                profs.endereco = tbendereco.Text;
                profs.celular = mtbcelular.Text;
                profs.email = tbemail.Text;
                profs.usuario = tbusuario.Text;
                profs.senha = tbsenha.Text;

                string cpf = mtbcpf.Text;
                string usuario = tbusuario.Text;

                Funcoes funcoes = new Funcoes();
                funcoes.verificarCpfProfessor(cpf, usuario, profs);
                tabControl1.SelectedTab = tabPage1;
            }
        }

        #region Retornar

        private void retornarToolStripMenuItem_Click(object sender, EventArgs e)
        {//strip >> retornar
            if (MessageBox.Show("Deseja mesmo retornar?", "Retornar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                Close();
        }

        private void Form3_KeyDown(object sender, KeyEventArgs e)
        {//ESC para retornar
            if (e.KeyValue.Equals(27))
                if (MessageBox.Show("Deseja mesmo retornar?", "Retornar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    Close();
        }

        #endregion
    }
}
