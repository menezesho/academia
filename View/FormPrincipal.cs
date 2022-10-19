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


        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void FormPrincipal_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Login realizado com sucesso!", "Login", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        #region Menu

        private void btInserirAluno_Click(object sender, EventArgs e)
        {//btInserirAluno
            FormCadAluno Fca = new FormCadAluno();
            Fca.Show();
        }

        private void btEditarAluno_Click(object sender, EventArgs e)
        {//btEditarAluno
            FormEditAluno Fea = new FormEditAluno();
            Fea.Show();
        }

        private void btInserirProf_Click(object sender, EventArgs e)
        {//btInserirProf
            FormCadProf Fcp = new FormCadProf();
            Fcp.Show();
        }

        private void btEditarProf_Click(object sender, EventArgs e)
        {//btEditarProf
            FormEditProf Fep = new FormEditProf();
            Fep.Show();
        }

        #endregion

        #region Sair

        private void FormPrincipal_KeyDown(object sender, KeyEventArgs e)
        {//ESC para retornar
            if (e.KeyValue.Equals(27))
                if (MessageBox.Show("Deseja mesmo sair para a tela de login?", "Sair", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    Close();
        }

        private void btSair_Click(object sender, EventArgs e)
        {//btSair
            if (MessageBox.Show("Deseja mesmo sair para a tela de login?", "Sair", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                Close();
        }

        #endregion
    }
}
