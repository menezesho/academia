using academia;
using academia.View;
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

        private void btCadAluno_Click(object sender, EventArgs e)
        {//btInserirAluno
            FormCadAluno Fca = new FormCadAluno();
            Fca.ShowDialog();
        }

        private void btEditarAluno_Click(object sender, EventArgs e)
        {//btEditarAluno
            FormEditAluno Fea = new FormEditAluno();
            Fea.ShowDialog();
        }

        private void btCadProf_Click(object sender, EventArgs e)
        {//btInserirProf
            FormCadProf Fcp = new FormCadProf();
            Fcp.ShowDialog();
        }

        private void btEditarProf_Click(object sender, EventArgs e)
        {//btEditarProf
            FormEditProf Fep = new FormEditProf();
            Fep.ShowDialog();
        }

        private void lbCadAula_Click(object sender, EventArgs e)
        {//btInserirAula
            FormCadAula Fcaula = new FormCadAula();
            Fcaula.ShowDialog();
        }

        private void lbEditarAula_Click(object sender, EventArgs e)
        {//btEditarAula
            FormEditAula Feaula = new FormEditAula();
            Feaula.ShowDialog();
        }

        private void btInserirAluno_Click(object sender, EventArgs e)
        {//btInserirAluno
            FormInserirAluno Fia = new FormInserirAluno();
            Fia.ShowDialog();
        }

        private void btInserirProf_Click(object sender, EventArgs e)
        {//btInserirProf
            FormInserirProf Fip = new FormInserirProf();
            Fip.ShowDialog();
        }

        private void btEditarParticipantes_Click(object sender, EventArgs e)
        {//btEditarParticipantes
            FormEditarParticipantes Feparticipantes = new FormEditarParticipantes();
            Feparticipantes.ShowDialog();
        }

        #endregion

        #region Sair

        private void FormPrincipal_KeyDown(object sender, KeyEventArgs e)
        {//ESC para sair
            if (e.KeyValue.Equals(27))
                if (MessageBox.Show("Deseja mesmo sair do programa?", "Sair", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    Application.Exit();
        }

        private void lbSair_Click(object sender, EventArgs e)
        {//btSair
            if (MessageBox.Show("Deseja mesmo sair do programa?", "Sair", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                Application.Exit();
        }

        private void FormPrincipal_FormClosed(object sender, FormClosedEventArgs e)
        {//fechando o formulário normalmente
            Application.Exit();
        }

        #endregion

    }
}
