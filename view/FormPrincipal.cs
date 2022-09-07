using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace projetofinal
{
    public partial class FormPrincipal : Form
    {
        public static FormCadAluno Fca = new FormCadAluno();
        public static FormEditAluno Fea = new FormEditAluno();
        public static FormCadProf Fcp = new FormCadProf();

        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void FormPrincipal_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Login realizado com sucesso!", "Login", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void FormPrincipal_KeyDown(object sender, KeyEventArgs e)
        {//ESC para retornar
            if (e.KeyValue.Equals(27))
                if (MessageBox.Show("Deseja mesmo sair para a tela de login?", "Sair", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    Close();
        }

        private void retornarToolStripMenuItem_Click_1(object sender, EventArgs e)
        {//strip >> retornar
            if (MessageBox.Show("Deseja mesmo sair para a tela de login?", "Sair", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                Close();
        }

        #region Aluno

        private void cadastrarToolStripMenuItem_Click(object sender, EventArgs e)
        {//strip >> alunos >> cadastrar
            Fca.ShowDialog();
        }

        private void listarToolStripMenuItem_Click(object sender, EventArgs e)
        {//strip >> alunos >> listar
            Fea.ShowDialog();
        }

        private void editarToolStripMenuItem_Click(object sender, EventArgs e)
        {//strip >> alunos >> editar
            Fea.ShowDialog();
        }

        private void excluirToolStripMenuItem2_Click(object sender, EventArgs e)
        {//strip >> alunos >> excluir
            Fea.ShowDialog();
        }

        #endregion


        #region Professor

        private void cadastrarToolStripMenuItem1_Click(object sender, EventArgs e)
        {//strip >> professores >> cadastrar
            Fcp.ShowDialog();
        }

        #endregion
    }
}
