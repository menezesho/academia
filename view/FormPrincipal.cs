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
        public static Form2 F2 = new Form2();
        public static Form1 F1 = new Form1();
        public static Form4 F4 = new Form4();
        public static Form3 F3 = new Form3(F4);
        public static FormListAluno Fla = new FormListAluno();

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

        private void cadastrarToolStripMenuItem_Click(object sender, EventArgs e)
        {//strip >> alunos >> cadastrar
            F1.ShowDialog();
        }

        private void listarToolStripMenuItem_Click(object sender, EventArgs e)
        {//strip >> alunos >> listar
            Fla.ShowDialog();
        }

        private void editarToolStripMenuItem_Click(object sender, EventArgs e)
        {//strip >> alunos >> editar
            Fla.ShowDialog();
        }

        private void excluirToolStripMenuItem2_Click(object sender, EventArgs e)
        {//strip >> alunos >> excluir
            Fla.ShowDialog();
        }
    }
}
