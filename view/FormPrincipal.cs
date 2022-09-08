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
        public static FormEditProf Fep = new FormEditProf();

        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void FormPrincipal_Load(object sender, EventArgs e)
        {//load
            MessageBox.Show("Login realizado com sucesso!", "Login", MessageBoxButtons.OK, MessageBoxIcon.Information);
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


        private void listarToolStripMenuItem1_Click(object sender, EventArgs e)
        {//strip >> professores >> listar
            Fep.ShowDialog();
        }

        private void editarToolStripMenuItem1_Click(object sender, EventArgs e)
        {//strip >> professores >> editar
            Fep.ShowDialog();
        }

        private void excluirToolStripMenuItem1_Click(object sender, EventArgs e)
        {//strip >> professores >> excluir
            Fep.ShowDialog();
        }

        #endregion

        #region Retornar

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

        #endregion
    }
}
